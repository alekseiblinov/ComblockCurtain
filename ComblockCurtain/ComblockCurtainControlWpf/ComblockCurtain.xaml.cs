using System;
using System.Windows;
using System.Windows.Controls;
using ComblockCurtainCommonLogic;
using static ComblockCurtainCommonLogic.CommonLogic;

namespace ComblockCurtainControlWpf
{
    /// <summary>
    /// WPF-контрол, являющийся шторкой с невидимыми кнопками, расположенными как цифры на кнопочном телефоне.
    /// </summary>
    public partial class ComblockCurtain : UserControl
    {
        /// <summary>
        /// Включен ли отладочный режим. В отладочном режиме цифры клавиатуры видны для пользователя. 
        /// </summary>
        public bool IsDebugMode
        {
            get
            {
#if DEBUG            
                return true;
#else
                return false;
#endif
            }
        }
        
        /// <summary>
        /// Текущее состояние шторки.
        /// </summary>
        private CurtainState _currentCurtainState;

        /// <summary>
        /// Текущее состояние шторки.
        /// </summary>
        public CurtainState CurrentCurtainState
        {
            get
            {
                return _currentCurtainState;
            }
            set 
            {  
                _currentCurtainState = value;

                // Если текущее состояние стало заблокированным, то
                if (_currentCurtainState == CurtainState.Locked)
                {
                    // Если включен режим отладки, то
                    if (IsDebugMode)
                    {
                        // Маленький жёлтый квадрат-заменитель не отображается.
                        rctStub.Visibility = Visibility.Hidden;
                    }

                    // Панель блокировки отображается.
                    grdKeypad.Visibility = Visibility.Visible;
                    // Генерация события о том, что панель заблокирована.
                    Locked?.Invoke();
                }
                // Если текущее состояние стало разблокированным, то
                else if (_currentCurtainState == CurtainState.Unlocked)
                {
                    // Если включен режим отладки, то
                    if (IsDebugMode)
                    {
                        // Отображается маленький жёлтый квадрат-заменитель.
                        rctStub.Visibility = Visibility.Visible;
                    }

                    // Панель блокировки скрывается. Делать её прозрачной недостаточно, пользователь должен иметь возможность взаимодействовать с другими контролами под ней.
                    grdKeypad.Visibility = Visibility.Collapsed;
                    // Генерация события о том, что панель разблокирована.
                    Unlocked?.Invoke();
                }
                else
                {
                    throw new InvalidOperationException($"Unknown curtain state when trying to change the state value: {_currentCurtainState}.");
                }
            }
        }
        
        /// <summary>
        /// Панель стала зблокированной.
        /// </summary>
        public event Action Locked;
        /// <summary>
        /// Панель стала разблокированной.
        /// </summary>
        public event Action Unlocked;

        public ComblockCurtain()
        {
            InitializeComponent();

            // Действует отладочный режим (DEBUG)?
            if (IsDebugMode)
            {
                // В режиме DEBUG контрол изначально имеет свёрнутый вид (в виде маленького квадрата).
                CurrentCurtainState = CurtainState.Unlocked;
            }
            else
            {
                // В режиме RELEASE маленький жёлтый квадрат-заменитель не отображается.
                rctStub.Visibility = Visibility.Hidden;
                // В режиме RELEASE клавиатура полностью прозрачна и не видна пользователю.
                grdKeypad.Opacity = 0;
                // В режиме RELEASE контрол имеет развёрнутый вид (в виде клавиатуры с цифрами).
                CurrentCurtainState = CurtainState.Locked;
            }
        }
        
        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "1".
        /// </summary>
        private void cmdDigit1_OnClick(object sender, RoutedEventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('1');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "2".
        /// </summary>
        private void cmdDigit2_OnClick(object sender, RoutedEventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('2');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "3".
        /// </summary>
        private void cmdDigit3_OnClick(object sender, RoutedEventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('3');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "4".
        /// </summary>
        private void cmdDigit4_OnClick(object sender, RoutedEventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('4');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "5".
        /// </summary>
        private void cmdDigit5_OnClick(object sender, RoutedEventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('5');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "6".
        /// </summary>
        private void cmdDigit6_OnClick(object sender, RoutedEventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('6');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "7".
        /// </summary>
        private void cmdDigit7_OnClick(object sender, RoutedEventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('7');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "8".
        /// </summary>
        private void cmdDigit8_OnClick(object sender, RoutedEventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('8');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "9".
        /// </summary>
        private void cmdDigit9_OnClick(object sender, RoutedEventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('9');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "0".
        /// </summary>
        private void cmdDigit0_OnClick(object sender, RoutedEventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('0');
        }

        /// <summary>
        /// Проверка после ввода пользователем очередной цифры.
        /// </summary>
        private void CheckUserInput(char digit)
        {
            // Вызов функции проверки введённых пользователем символов на соответствие секретному ключу.
            CurtainState curtainState = CommonLogic.CheckUserInput(digit, CurrentCurtainState, IsDebugMode);

            // Если состояние шторки изменилось, то
            if (curtainState != CurrentCurtainState)
            {
                // Сохранение текущего состояния шторки.
                CurrentCurtainState = curtainState;
            }
        }

        /// <summary>
        /// Обработка нажатия пользователем на маленький жёлтый квадрат, служащий заменителем шторки в режиме отладки.
        /// </summary>
        private void rctStub_OnClick(object sender, RoutedEventArgs e)
        {
            // Шторка переводится в заблокированное состояние.
            CurrentCurtainState = CurtainState.Locked;
        }
    }
}
