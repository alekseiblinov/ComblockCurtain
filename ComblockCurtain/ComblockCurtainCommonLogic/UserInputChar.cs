using System;

namespace ComblockCurtainCommonLogic
{
    /// <summary>
    /// Данные о введённом пользователем символе с клавиатуры.
    /// </summary>
    internal class UserInputChar
    {
        /// <summary>
        /// Дата и время ввода символа пользователем.
        /// </summary>
        internal DateTime InputDateTime { get; set; }
        /// <summary>
        /// Введённый пользователем символ.
        /// </summary>
        internal char InputChar { get; set; }

        public UserInputChar(char inputChar)
        {
            InputDateTime = DateTime.Now;
            InputChar = inputChar;
        }
    }
}