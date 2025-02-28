using System.Windows;
using ComblockCurtainCommonLogic;

namespace ComblockCurtainTestAppWpf
{
    /// <summary>
    /// Тестовая форма для проверки WPF-контрола ComblockCurtain.
    /// </summary>
    public partial class ComblockCurtainTest : Window
    {
        /// <summary>
        /// Переменная для хранения данных модели представления данного окна.
        /// </summary>
        private readonly ComblockCurtainViewModel _viewModel;

        public ComblockCurtainTest()
        {
            InitializeComponent();

            // Значение размытия изображения (отображается или нет шторка).
            int curtainBlurRadius;
            udcEarningInProgress.CurrentCurtainState = CommonLogic.CurtainState.Unlocked;
#if DEBUG
    // В режиме DEBUG контрол изначально имеет свёрнутый вид (в виде маленького квадрата), поэтому размытие отключается.
    curtainBlurRadius = ComblockCurtainModel.CURTAIN_BLUR_RADIUS_NO_BLURRED;
#else
    // В режиме RELEASE контрол изначально имеет развёрнутый вид, поэтому размытие включается.
    curtainBlurRadius = ComblockCurtainModel.CURTAIN_BLUR_RADIUS_BLURRED;
#endif
            // Формирование данных модели и вьюмодели.
            _viewModel = new ComblockCurtainViewModel(new ComblockCurtainModel(curtainBlurRadius));
            // Передача вьюмодели на форму.
            DataContext = _viewModel;
            // Подключение обработки событий влокирования и разблокирования щторки встроенного браузера.
            udcEarningInProgress.Locked += udcEarningInProgress_Locked;
            udcEarningInProgress.Unlocked += udcEarningInProgress_Unlocked;
        }

        /// <summary>
        /// Обработка сигнала о необходимости включить размытие изображения во встроенном браузере.
        /// </summary>
        private void udcEarningInProgress_Locked()
        {
            // На случай если размытие уже включено начальный отсчёт счётчика ведётся от текущего действующего значения.
            int counter = _viewModel.CurtainBlurRadius;

            // Шторка плавно появляется.
            while (counter < ComblockCurtainModel.CURTAIN_BLUR_RADIUS_BLURRED)
            {
                counter += 5;

                // Выравнивание значения на случай если в результате работы цикла с шагом более единицы оно стало больше максимально возможного.
                if (counter > ComblockCurtainModel.CURTAIN_BLUR_RADIUS_BLURRED)
                {
                    _viewModel.CurtainBlurRadius = ComblockCurtainModel.CURTAIN_BLUR_RADIUS_BLURRED;
                }
                else
                {
                    _viewModel.CurtainBlurRadius = counter;
                    //CommonLogic.WaitWithDoEvents(20);
                }
            }
        }

        /// <summary>
        /// Обработка сигнала о необходимости отключить размытие изображения во встроенном браузере.
        /// </summary>
        private void udcEarningInProgress_Unlocked()
        {
            // На случай если размытие уже отключено начальный отсчёт счётчика ведётся от текущего действующего значения.
            int counter = _viewModel.CurtainBlurRadius;

            // Шторка плавно скрывается.
            while (counter > ComblockCurtainModel.CURTAIN_BLUR_RADIUS_NO_BLURRED)
            {
                counter -= 5;

                // Выравнивание значения на случай если в результате работы цикла с шагом более единицы оно стало менее минимально возможного.
                if (counter < ComblockCurtainModel.CURTAIN_BLUR_RADIUS_NO_BLURRED)
                {
                    _viewModel.CurtainBlurRadius = ComblockCurtainModel.CURTAIN_BLUR_RADIUS_NO_BLURRED;
                }
                else
                {
                    _viewModel.CurtainBlurRadius = counter;
                    //CommonLogic.WaitWithDoEvents(40);
                }
            }
        }
    }
}
