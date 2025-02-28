using System.Threading;

namespace ComblockCurtainTestAppWpf
{
    public class CommonLogic
    {
        /// <summary>
        /// Пауза в выполнении указанной длительности с периодическим вызовом метода DoEvents для того, чтобы UI не терял отзывчивость.
        /// </summary>
        /// <param name="durationMilliseconds"> Длительность паузы </param>
        public static void WaitWithDoEvents(int durationMilliseconds = 5000)
        {
            // Замедление работы программы в зависимости от количества ошибок  загрузки страниц.
            int steps = (int)(durationMilliseconds * SpeedControl.SlowdownCoefficient / 100);

            // Пауза выдерживается пока активна накрутка.
            for (int i = 0; i <= steps && SingletonGlobals.ViewingInProgress; i++)
            {
                DoEvents();
                Thread.Sleep(100);
            }
        }
    }
}