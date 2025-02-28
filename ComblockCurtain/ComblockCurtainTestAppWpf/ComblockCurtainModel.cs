namespace ComblockCurtainTestAppWpf
{
    /// <summary>
    /// Данные, описывающие информацию, представленную в окне шторки. POCO.
    /// </summary>
    public class ComblockCurtainModel
    {
        /// <summary>
        /// Степень размытия изображения: размытый.
        /// </summary>
        public const int CURTAIN_BLUR_RADIUS_BLURRED = 20;
        /// <summary>
        /// Степень размытия изображения: без размытия.
        /// </summary>
        public const int CURTAIN_BLUR_RADIUS_NO_BLURRED = 0;

        /// <summary>
        /// Степень размытия изображения. 0 - размытие отсутствует.
        /// </summary>
        internal readonly int CurtainBlurRadius;

        public ComblockCurtainModel(int curtainBlurRadius)
        {
            CurtainBlurRadius = curtainBlurRadius;
        }
    }
}