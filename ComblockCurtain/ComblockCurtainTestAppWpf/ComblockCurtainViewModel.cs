namespace ComblockCurtainTestAppWpf
{
    /// <summary>
    /// Данные, описывающие информацию, представленную в контроле шторка. Для отображения во вью.
    /// </summary>
    public class ComblockCurtainViewModel : ViewModelBase<ComblockCurtainModel>
    {
        #region Свойства для привязки из вью.
        /// <summary>
        /// Степень размытия не шторке.
        /// </summary>
        public int CurtainBlurRadius
        {
            get => _curtainBlurRadius;
            set => SetPropertyValue(ref _curtainBlurRadius, value);
        }
        #endregion Свойства для привязки из вью.

        #region Служебные переменные для хранения значений свойств, к которым производится привязка значений из вью.
        private int _curtainBlurRadius;
        #endregion Служебные переменные для хранения значений свойств, к которым производится привязка значений из вью.

        public ComblockCurtainViewModel(ComblockCurtainModel model) : base(model)
        {
            CurtainBlurRadius = model.CurtainBlurRadius;
        }
    }
}