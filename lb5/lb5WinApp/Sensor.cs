using lb5WinApp.Properties;
using System.Drawing;
using System.Text;

namespace lb5WinApp
{
    /// <summary>
    /// Класс-подписчик. Датчик
    /// </summary>
    public class Sensor
    {
        private Form1 _form;

        public Sensor(Form1 form) => _form = form;

        /// <summary>
        /// Реакция на событие - изменение значений на градуснике, при изменении температуры.
        /// </summary>
        /// <param name="t">Температура.</param>
        public void ChangeTemperature(int t)
        {
            _form.Thermometr.Image = Resources.ResourceManager.GetObject($"{t}") as Image;
        }

        /// <summary>
        /// Реакция на событие - занемение в журнал записи, об изменении температуры.
        /// </summary>
        /// <param name="t">Температура.</param>
        public void Journal(int t)
        {
            _form.Journal.Text += $"Время: {DateTime.Now.ToLongTimeString()}, температура: {t} °C\n";
        }

        /// <summary>
        /// Реакция на событие - срабатывание датчика. Проверка включить или выключить отопление.
        /// </summary>
        /// <param name="t">Температура.</param>
        public void Gauge(int t)
        {
            var text = _form.GaugeBox.SelectedItem as string;
            var stringBuilder = new StringBuilder();
            foreach (var c in text)
            {
                if (char.IsDigit(c) || c == '-')
                {
                    stringBuilder.Append(c);
                }
            }

            int option = int.Parse(stringBuilder.ToString());

            if (t - option <= 0)
                _form.Status.Text = "Отопление: включено";
            else
                _form.Status.Text = "Отопление: выключено";
        }
    }
}
