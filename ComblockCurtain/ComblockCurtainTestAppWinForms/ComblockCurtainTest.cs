using System.Drawing;
using System.Windows.Forms;

namespace ComblockCurtainTestAppWinForms
{
    /// <summary>
    /// Тестовая форма для проверки WinForms-контрола ComblockCurtain.
    /// </summary>
    public partial class ComblockCurtainTest : Form
    {
        /// <summary>
        /// Отступы от краёв формы для шторки.
        /// </summary>
        private const int EARNING_POINTS_PANEL_MARGIN_X = 30;
        private const int EARNING_POINTS_PANEL_MARGIN_Y = 20;

        /// <summary>
        /// Работает ли контрол в режиме отладки.
        /// </summary>
        private static bool _isDebugMode;

        public ComblockCurtainTest()
        {
            InitializeComponent();

            // Установка значения переменной-флага отладочного режима.
#if DEBUG            
            _isDebugMode = true;
#endif
            udcCurtain.IsDebugMode = _isDebugMode;
            // Подписка на событие перехода шторки в заблокированный режим. 
            udcCurtain.Locked += udcCurtain_Locked;
        }

        /// <summary>
        /// Обработка события изменения размера формы пользователем.
        /// </summary>
        private void ComblockCurtainTest_ClientSizeChanged(object sender, System.EventArgs e)
        {
            // Вызов функции установки расположения и размеров шторки. 
            SetEarningInProgressCurtainSize();
        }

        /// <summary>
        /// Обработка перехода шторки в заблокированный режим. 
        /// </summary>
        private void udcCurtain_Locked()
        {
            // Вызов функции установки расположения и размеров шторки. 
            SetEarningInProgressCurtainSize();
        }

        /// <summary>
        /// Установка расположения и размеров шторки. 
        /// </summary>
        private void SetEarningInProgressCurtainSize()
        {
            // Шторка закрывает бОльшу часть встроенного браузера, чтобы нельзя было увидеть какие каналы накручиваются.
            udcCurtain.Location = new Point(EARNING_POINTS_PANEL_MARGIN_X, EARNING_POINTS_PANEL_MARGIN_Y);
            udcCurtain.Size = new Size(ClientRectangle.Width - 2 * EARNING_POINTS_PANEL_MARGIN_X, ClientRectangle.Height - 2 * EARNING_POINTS_PANEL_MARGIN_Y);
        }

        /// <summary>
        /// Обработка нажатия на кнопку на тестовой форме.
        /// </summary>
        private void cmdTestFormBottomButton_Click(object sender, System.EventArgs e)
        {
            ComblockCurtainCommonLogic.CommonLogic.LogWriteLine("The bottom button on the test form is pressed.", _isDebugMode);
        }
    }
}
