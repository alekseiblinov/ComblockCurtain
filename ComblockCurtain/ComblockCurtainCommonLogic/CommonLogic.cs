using System;
using System.Collections.Generic;
using System.Linq;

namespace ComblockCurtainCommonLogic
{
    /// <summary>
    /// Общие функции и данные.
    /// </summary>
    public abstract class CommonLogic
    {
        /// <summary>
        /// Период времени в секундах, в течение которого хранятся введённые пользователем символы. За этот период пользователь должен успеть ввести код разблокировки или блокировки.
        /// </summary>
        private const int  TIME_TO_INPUT_KEY_SECONDS = 60;
        /// <summary>
        /// Последовательность цифр для блокировки и разблокировки.
        /// </summary>
        private const string LOCKER_SEQUENCE = "054321";
        /// <summary>
        /// Последовательность цифр для упрощённой блокировки и разблокировки в режиме отладки.
        /// </summary>
        private const string LOCKER_SEQUENCE_DEBUG = "000";

        /// <summary>
        /// Коллекция для хранения введённых пользователем символов.
        /// </summary>
        private static List<UserInputChar> _lastUserInputChars = new List<UserInputChar>();

        /// <summary>
        /// Состояние шторки.
        /// </summary>
        public enum CurtainState
        {
            Locked,
            Unlocked
        }

        /// <summary>
        /// Проверка введённых пользователем символов на соответствие секретному ключу.
        /// </summary>
        /// <param name="charInput"> Очередной введённый пользователем символ. </param>
        /// <param name="currentCurtainState"> Текущее состояние контрола-шторки. </param>
        /// <param name="isDebugMode"> Включен ли режим отладки. </param>
        public static CurtainState CheckUserInput(char charInput, CurtainState currentCurtainState, bool isDebugMode)
        {
            CurtainState result = currentCurtainState;
            // Получение ключа - последовательности символов, которая разблокирует шторку.
            string key = LOCKER_SEQUENCE;

            // В последовательность введённых пользователем символов добавить новый введённый символ.
            UserInputChar newInputChar = new UserInputChar(charInput);
            _lastUserInputChars.Add(newInputChar);
            // Из последовательности введённых пользователем символов убрать устаревшие.
            _lastUserInputChars = _lastUserInputChars
                .Where(i => i.InputDateTime >= DateTime.Now.AddSeconds(-TIME_TO_INPUT_KEY_SECONDS))
                // Из последовательности введённых пользователем символов отбросить ранние, выходящие за пределы длины ключа. Они будут только напрасно загромождать память.
                .Skip(Math.Max(0, _lastUserInputChars.Count - key.Length))
                .ToList();

            // Переменная для хранения введённых пользователем символов в виде строки. 
            string userInputString = string.Empty;

            // Сбор оставшихся в последовательности введённых пользователем символов в строку. 
            foreach (UserInputChar currentUserInputChar in _lastUserInputChars)
            {
                userInputString = $"{userInputString}{currentUserInputChar.InputChar}";
            }

            // Если последние введённые пользователем символы совпадают с ключом, то
            if (userInputString == key
                    // Если производится отладка и последние введённые пользователем символы являются служебной последовательностью для блокировки ли разблокировки, то
                    || (isDebugMode && GetLastSymbols(userInputString, LOCKER_SEQUENCE_DEBUG.Length) == LOCKER_SEQUENCE_DEBUG))
            {
                if (currentCurtainState == CurtainState.Locked)
                {
                    LogWriteLine("The control is unlocked by user input.", isDebugMode);
                    // Панель разблокируется.
                    result = CurtainState.Unlocked;
                }
                else if (currentCurtainState == CurtainState.Unlocked)
                {
                    LogWriteLine("The control is locked by user input.", isDebugMode);
                    // Панель блокируется.
                    result = CurtainState.Locked;
                }
                else
                {
                    // Генерация неожидаемого исключения. 
                    throw new ArgumentException($"Unknown curtain state when checking user input: {currentCurtainState}.");
                }

                // Сброс введённой пользователем последовательности после успешного действия.
                _lastUserInputChars.Clear();
            }
            
            LogWriteLine($"Current input sequence: {userInputString}", isDebugMode);
            LogWriteLine($"The control state: {result}", isDebugMode);

            return result;
        }

        /// <summary>
        /// Получение указанного количества последних символов из строки.
        /// </summary>
        private static string GetLastSymbols(string userInputString, int numberOfSymbols)
        {
            string lastNSymbols = userInputString.Length > numberOfSymbols ? 
                userInputString.Substring(userInputString.Length - numberOfSymbols) : 
                userInputString;

            return lastNSymbols;
        }

        /// <summary>
        /// Запись строки в лог.
        /// </summary>
        /// <param name="text"> Текст для записи в лог. </param>
        /// <param name="isDebugMode"> Включен ли режим отладки. </param>
        public static void LogWriteLine(string text, bool isDebugMode = false)
        {
            if (isDebugMode)
            {
                Console.WriteLine(text);
            }
        }
    }
}
