namespace lb5WinApp
{
    /// <summary>
    /// Класс-источник события.
    /// </summary>
    public class Temperature
    {
        /// <summary>
        /// Делегат событий.
        /// </summary>
        /// <param name="t">Температура.</param>
        public delegate void TemperatureReached(int t);

        public TemperatureReached temperatureReached = delegate { };

        private int tepmerature = 0;
        /// <summary>
        /// Событие - повышение температуры погодой.
        /// </summary>
        public void AddTen()
        {
            if (tepmerature < 50)
                tepmerature += 10;
            temperatureReached(tepmerature);
        }
        /// <summary>
        /// Событие - понижение температуры погодой.
        /// </summary>
        public void SubTen()
        {
            if (tepmerature > -50)
                tepmerature -= 10;
            temperatureReached(tepmerature);
        }
        public int GetTemperature()
        {
            return tepmerature;
        }
    }
}
