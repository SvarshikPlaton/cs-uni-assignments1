/******************************************************/
/*               Лабораторная работа № 4              */
/*      Абстрактные сущности и связи между ними       */
/*                      Задание 2                     */
/*       Выполнил студент гр. 515ст2 Немов Н.Р.       */
/******************************************************/

using System;
using System.Collections.Generic;

namespace Lab02FormApp
{
    public class Watch : IComparable<Watch>
    {
        /// <summary>
        /// Бренд часов.
        /// </summary>
        private readonly string brand;
        /// <summary>
        /// Бренд модели.
        /// </summary>
        private readonly string model;


        /// <summary>
        /// Последний индекс созданных часов.
        /// </summary>
        private static int index = DateTime.Now.Year % 100 * 100000;
        /// <summary>
        /// Серийный номер часов.
        /// </summary>
        private string serialNumber;

        /// <summary>
        /// Текущее время часов.
        /// </summary>
        private DateTime time;
        /// <summary>
        /// Признак подачи питания.
        /// </summary>
        private bool power = false;
        /// <summary>
        /// Признак включенной подсветки.
        /// </summary>
        private bool backlight = false;
        /// <summary>
        /// Текущий часовой пояс часов.
        /// </summary>
        private GeoTime geo = GeoTime.EastAmerica;
        /// <summary>
        /// Установленное время будильника.
        /// </summary>
        private DateTime alarmClock = DateTime.MinValue;
        /// <summary>
        /// Признак включенного будильника.
        /// </summary>
        private bool alarmWatchState = false;

        /// <summary>
        /// Конструктор часов без параметров.
        /// </summary>
        public Watch() {
            brand = "Noname";
            model = "Unknown";

            time = DateTime.MinValue;
            SetID();
        }

        /// <summary>
        /// Конструктор часов с параметром: названием бренда.
        /// </summary>
        /// <param name="brand">Название бренда. </param> 
        public Watch(string brand) {
            this.brand = brand;
            model = "Unknown";

            time = DateTime.MinValue;
            SetID();
        }

        /// <summary>
        /// Конструктор часов с параметрами: название бренда, название модели.
        /// </summary>
        /// <param name="brand">Название бренда.</param>
        /// <param name="model">Название модели.</param>
        public Watch(string brand, string model) {
            this.brand = brand;
            this.model = model;

            time = DateTime.MinValue;
            SetID();
        }

        /// <summary>
        /// Конструктор часов с параметрами: название бренда, название модели, установка времени, установка часового пояса.
        /// </summary>
        /// <param name="brand">Название бренда.</param>
        /// <param name="model">Название модели.</param>
        /// <param name="time">Дата и время. Пример: 18.18.2018 07:00:00</param>
        /// <param name="geo">Часовой пояс.</param>
        public Watch(string brand, string model, string time, GeoTime geo) {
            this.brand = brand;
            this.model = model;

            TurnPower();
            TurnBacklight();
            this.time = DateTime.Parse(time);
            this.geo = geo;
            SetID();
        }

        /// <summary>
        /// Установление серийного номера часов.
        /// </summary>
        private void SetID() {
            index++;
            serialNumber = index.ToString();
        }
        /// <summary>
        /// Включить / выключить питание часов.
        /// </summary>
        public void TurnPower() {
            power = !power;
            if (!power) {
                backlight = false;
                alarmWatchState = false;
            }
        }

        /// <summary>
        /// Включить / выключить подсветку часов. Работает только при включенном питаннии.
        /// </summary>
        public void TurnBacklight() {
            if (power)
                backlight = !backlight;

        }

        /// <summary>
        /// Задать часовой пояс часов. Работает только при включенном питаннии.
        /// </summary>
        /// <param name="geo">Часовой пояс.</param>
        public void SetGeo(GeoTime geo) {
            if (power)
                this.geo = geo;
        }

        /// <summary>
        /// Установление времени будильника. Работает только при включенном питаннии и включенном будильнике.
        /// </summary>
        /// <param name="newAlarmClockTime">Дата и время. Пример: 18.18.2018 07:00:00</param>
        public void SetAlarm(string newAlarmClockTime) {
            if (alarmWatchState && DateTime.TryParse(newAlarmClockTime,out DateTime alarmClock)&& alarmClock > time) 
                this.alarmClock = alarmClock;
        }

        /// <summary>
        /// Включить / выключить будильник.
        /// </summary>
        public void TurnAlarmWatch() {
            if (power)
                alarmWatchState = !alarmWatchState;
        }

        /// <summary>
        /// Установление времени часов.
        /// </summary>
        /// <param name="newTime">Дата и время. Пример: 18.18.2018 07:00:00</param>
        public void SetTime(string newTime) {
            if (power && DateTime.TryParse(newTime, out DateTime time))
                this.time = time;
        }

        /// <summary>
        /// Получение информации об общем состоянии часов через строку.
        /// </summary>
        /// <returns></returns>
        public string GetStatus() {
            return $"S/N: {serialNumber} | The {brand} {model} watch shows {(time == DateTime.MinValue || !power ? "nothing" : time.ToString())}" +
                $". The power is {(power ? "on" : "off")}" +
                $". The alarm {(alarmWatchState ? "will" : "won't")} start for {(alarmClock == DateTime.MinValue ? "never" : alarmClock.ToString())}" +
                $". The backlight is {(backlight ? "on" : "off")}" +
                $". Current time zone {geo.ToString()}. ";
        }

        /// <summary>
        /// Сортировать по серийному номеру.
        /// </summary>
        /// <param name="obj">Объект экземпляра часов.</param>
        /// <returns>Отсортированный массив экземпляров часов по индексу.</returns>
        public int CompareTo(Watch obj)
        {
            return this.serialNumber.CompareTo(obj.serialNumber);
        }

        /// <summary>
        /// Сортировать по установленному времени.
        /// </summary>
        public class TimeComparer : IComparer<Watch>
        {
            int IComparer<Watch>.Compare(Watch x, Watch y)
            {
                if (x.time > y.time)
                    return 1;
                else if (x.time < y.time)
                    return -1;
                else
                    return 0;
            }
        }

        /// <summary>
        /// Сортировать по временному поясу
        /// </summary>
        public class GeoComparer : IComparer<Watch>
        {
            int IComparer<Watch>.Compare(Watch x, Watch y)
            {
                if (x.geo > y.geo)
                    return 1;
                else if (x.geo < y.geo)
                    return -1;
                else
                    return 0;
            }
        }

        /// <summary>
        /// Сортировать по заданному времени будильника.
        /// </summary>
        public class AlarmClockComparer : IComparer<Watch>
        {
            int IComparer<Watch>.Compare(Watch x, Watch y)
            {
                if (x.alarmClock > y.alarmClock)
                    return 1;
                else if (x.alarmClock < y.alarmClock)
                    return -1;
                else
                    return 0;
            }
        }

    }
}
