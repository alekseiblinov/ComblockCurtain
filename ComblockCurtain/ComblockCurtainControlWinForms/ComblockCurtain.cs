using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ComblockCurtainCommonLogic;
using static ComblockCurtainCommonLogic.CommonLogic;

namespace ComblockCurtainControlWinForms
{
    public partial class ComblockCurtain: UserControl
    {
        /// <summary>
        /// Включен ли отладочный режим. В отладочном режиме цифры клавиатуры видны для пользователя. 
        /// </summary>
        public bool IsDebugMode { get; set; }

        // Размер контрола в состоянии "разблокировано". Он представляет собой маленький жёлтый квадрат.
        private readonly Size _unlockedBannerSize = new Size(20, 20);

        /// <summary>
        /// Текущее состояние шторки.
        /// </summary>
        private CurtainState _currentCurtainState;

        /// <summary>
        /// Текущее состояние шторки.
        /// </summary>
        private CurtainState CurrentCurtainState
        {
            get => _currentCurtainState;
            set 
            {  
                _currentCurtainState = value;

                // Если панель заблокирована, то
                if (_currentCurtainState == CurtainState.Locked)
                {
                    // Маленькая панель-заменитель, служащая для замены контрола ввода, скрывается.
                    pnlUnlockedBanner.Visible = false;
                    // Панель с кнопками для ввода кода становится видимой.
                    pnlMain.Visible = true;
                    Visible = true;
                    // Отключение обработки нажатия на этот квадратик для восстановления блокировки.
                    RemoveClickHandlerRecursivel(this);
                    // Уведомление подписчиков о том, что панель заблокирована.
                    Locked?.Invoke();
                }
                // Если панель разблокирована, то
                else if (_currentCurtainState == CurtainState.Unlocked)
                {
                    // Если активен отладочный режим, то
                    if (IsDebugMode)
                    {
                        pnlMain.Visible = false;
                        // Уменьшение размера контрола для ввода кода.
                        Size = _unlockedBannerSize;
                        // Вместо контрола для ввода кода отображается маленькая панель-заменитель жёлтого цвета.
                        pnlUnlockedBanner.Visible = true;
                    }
                    // Если активен режим RELEASE, то
                    else
                    {
                        // Панель с кнопками для ввода кода становится невидимой.
                        Visible = false;
                    }

                    // Добавление обработки нажатия на этот квадратик для восстановления блокировки.
                    AddClickHandlerRecursively(this);
                    // Уведомление подписчиков о том, что панель разблокирована.
                    Unlocked?.Invoke();
                }
                else
                {
                    throw new InvalidOperationException("Unknown curtain state");
                }
            }
        }

        /// <summary>
        /// Текст надписи на шторке.
        /// </summary>
        [Category("Appearance"), Description("The text on the curtain.")]  
        public string CurtainText { get; set; }

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
        }

        /// <summary>
        /// Загружен ли контрол полностью или находится в стадии загрузки.
        /// </summary>
        private bool _isLoaded;

        private void ComblockCurtain_Load(object sender, EventArgs e)
        {
            // Установка режима отладки для цифр клавиатуры согласно заданному у контрола значению.
            SetDebugModeRecursively(this);
            // Установка текста на шторке.
            lblEarningInProgress.Text = CurtainText;

            // Если активен отладочный режим, то
            if (IsDebugMode)
            {
                // В отладочном режиме контрол изначально имеет свёрнутый вид (в виде маленького жёлтого квадрата).
                CurrentCurtainState = CurtainState.Unlocked;
            }
            else
            {
                // В режиме RELEASE контрол изначально имеет развёрнутый вид.
                CurrentCurtainState = CurtainState.Locked;
            }

            // Установка признака, обозначающего что контрол полностью загружен.
            _isLoaded = true;
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "1".
        /// </summary>
        private void cmdDigit1_Click(object sender, EventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('1');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "2".
        /// </summary>
        private void cmdDigit2_Click(object sender, EventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('2');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "3".
        /// </summary>
        private void cmdDigit3_Click(object sender, EventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('3');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "4".
        /// </summary>
        private void cmdDigit4_Click(object sender, EventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('4');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "5".
        /// </summary>
        private void cmdDigit5_Click(object sender, EventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('5');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "6".
        /// </summary>
        private void cmdDigit6_Click(object sender, EventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('6');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "7".
        /// </summary>
        private void cmdDigit7_Click(object sender, EventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('7');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "8".
        /// </summary>
        private void cmdDigit8_Click(object sender, EventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('8');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "9".
        /// </summary>
        private void cmdDigit9_Click(object sender, EventArgs e)
        {
            // Вызов функции проверки после ввода пользователем очередной цифры.
            CheckUserInput('9');
        }

        /// <summary>
        /// Обработка нажатия пользователем на кнопку с цифрой "0".
        /// </summary>
        private void cmdDigit0_Click(object sender, EventArgs e)
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
        /// Установка режима отладки для цифр клавиатуры согласно заданному у контрола значению.
        /// </summary>
        private void SetDebugModeRecursively(Control control)
        {
            // Если рассматриваемый контрол является кнопкой, то
            if (control is TransparentButton)
            {
                // Установка режима отладки для цифр клавиатуры согласно заданному у контрола значению.
                ((TransparentButton)control).IsDebugMode = IsDebugMode;
            }

            // Рекурсивный вызов этой же функции для всех дочерних контролов.
            foreach (Control subControl in control.Controls)
            {
                SetDebugModeRecursively(subControl);
            }
        }

        /// <summary>
        /// Добавление перехвата нажатия пользователем мыши на контроле для ввода кода.
        /// </summary>
        private void AddClickHandlerRecursively(Control control)
        {
            // Подключение функции перехвата нажатия.
            control.Click += control_Click;

            // Рекурсивный перебор всех дочерних контролов.
            foreach (Control subControl in control.Controls)
            {
                AddClickHandlerRecursively(subControl);
            }
        }

        /// <summary>
        /// Отключение перехвата нажатия пользователем мыши на контроле для ввода кода.
        /// </summary>
        private void RemoveClickHandlerRecursivel(Control control)
        {
            // Отключение функции перехвата нажатия.
            control.Click -= control_Click;

            // Рекурсивный перебор всех дочерних контролов.
            foreach (Control subControl in control.Controls)
            {
                RemoveClickHandlerRecursivel(subControl);
            }
        }

        /// <summary>
        /// Обработка нажатия пользователем на маленькую панель-заменитель.
        /// </summary>
        private void control_Click(object sender, EventArgs e)
        {
            // Контрол переходит в заблокированное состояние.
            CurrentCurtainState = CurtainState.Locked;
        }

        /// <summary>
        /// Обработка попытки измененить размер контрола ввода кода.
        /// </summary>
        private void ComblockCurtain_ClientSizeChanged(object sender, EventArgs e)
        {
            // Если контрол полностью загружен, то 
            if (_isLoaded)
            {
                // Если контрол находится в состоянии "разблокировано", активен отладочный режим и контрол ещё не свёрнут в маленький жёлтый квадрат, то
                if (CurrentCurtainState == CurtainState.Unlocked
                    && IsDebugMode
                    && Size != _unlockedBannerSize)
                {
                    // Вид контрола в состоянии "разблокировано" и отладочном режиме представляет собой маленький жёлтый квадрат. При изменении размеров форма его размер не изменяется.
                    Size = _unlockedBannerSize;
                }
            }
        }
    }
}
