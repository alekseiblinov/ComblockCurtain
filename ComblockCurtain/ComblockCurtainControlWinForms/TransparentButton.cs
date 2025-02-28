using System.Drawing;
using System.Windows.Forms;

namespace ComblockCurtainControlWinForms
{
    /// <summary>
    /// Кнопка с прозрачным фоном.
    /// </summary>
    public sealed class TransparentButton : Label
    {
        /// <summary>
        /// Отладочный режим. В нём цифры клавиатуры видны для пользователя. 
        /// </summary>
        public bool IsDebugMode { get; set; }

        public TransparentButton()
        {
            // Настройка внешнего вида внутренней части кнопки.
            SuspendLayout();
            AutoSize = false;
            Dock = DockStyle.Fill;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            ForeColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.None;
            ResumeLayout(false);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Если включен отладочный режим, то
            if (IsDebugMode)
            {
                // В режиме отладки видна рамка кнопок. Настройка внешнего вида рамки кнопки.
                ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                    SystemColors.ControlLight, 1, ButtonBorderStyle.Solid,
                    SystemColors.ControlLight, 1, ButtonBorderStyle.Solid,
                    SystemColors.ControlLight, 1, ButtonBorderStyle.Solid,
                    SystemColors.ControlLight, 1, ButtonBorderStyle.Solid);
            }
            else
            {
                // В режиме RELEASE кнопки и надписи не них не должны быть видны.
                Text = string.Empty;
            }

            base.OnPaint(e);
        }
    }
}