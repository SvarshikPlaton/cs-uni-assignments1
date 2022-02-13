using System.Windows.Forms;

namespace lb5WinApp
{
    public partial class Form1 : Form
    {
        
        /// <summary>
        /// Экземпляр класса-подписчика.
        /// </summary>
        public Sensor temperaturSensor;

        /// <summary>
        /// Экземпляр класса-источника события.
        /// </summary>
        public Temperature temperature;

        /// <summary>
        /// Ссылки на объекты для классов.
        /// </summary>
        public ComboBox GaugeBox => gaugeBox;
        public PictureBox Thermometr => thermometr;
        public RichTextBox Journal => journal;
        public GroupBox Status => status;

        public Form1()
        {
            InitializeComponent();
            gaugeBox.SelectedIndex = 5;

            temperaturSensor = new Sensor(this);
            temperature = new Temperature();

            // Добавление подписок на экземпляр класса-источника событий 
            temperature.temperatureReached += temperaturSensor.ChangeTemperature;
            temperature.temperatureReached += temperaturSensor.Journal;
            temperature.temperatureReached += temperaturSensor.Gauge;

            temperaturSensor.Journal(temperature.GetTemperature());
        }
        
        private void plusTemperature_Click(object sender, EventArgs e) => temperature.AddTen();

        private void minusTemperature_Click(object sender, EventArgs e) => temperature.SubTen();
    }
}
