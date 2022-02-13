using System;

namespace ClassLibraryProduct
{
    public class CountProduct : Product
    {
        /// <summary>
        /// Количество товара поштучно.
        /// </summary>
        private int count;
        /// <summary>
        /// Цвет товара.
        /// </summary>
        private string color;
        /// <summary>
        /// Код товара.
        /// </summary>
        private int code;
        static private int DataCode = DateTime.Now.Year % 100 * 100000;

        /// <summary>
        /// Конструктор класса товара без параметров.
        /// </summary>
        public CountProduct() : base()
        {
            SetCount(0);
            SetColor("Black");
            SetCode();
        }

        /// <summary>
        /// Конструктор класса товара с параметрами: именование, цена, количество.
        /// </summary>
        /// <param name="name">Именование.</param>
        /// <param name="producer">Производитель.</param>
        /// <param name="date">Дата изготовления.</param>
        /// <param name="price">Цена.</param>
        /// <param name="comment">Комментарий.</param>
        public CountProduct(string name, string producer, string date, float price, string comment) : base(name, producer, date, price, comment)
        {
            SetCount(0);
            SetColor("Black");
            SetCode();
        }

        /// <summary>
        /// Конструктор класса товара с параметрами: именование, производитель, дата изготовления, цена, количество.
        /// </summary>
        /// <param name="name">Именование.</param>
        /// <param name="producer">Производитель.</param>
        /// <param name="date">Дата изготовления.</param>
        /// <param name="price">Цена.</param>
        /// <param name="comment">Комментарий.</param>
        /// <param name="count">Количество.</param>
        public CountProduct(string name, string producer, string date, float price, string comment, int count) : base(name, producer, date, price, comment)
        {
            SetCount(count);
            SetColor("unknown");
            SetCode();
        }

        public CountProduct(float price)
        {
            this.price = price;
        }

        /// <summary>
        /// Конструктор класса товара с параметрами: именование, производитель, дата изготовления, цена, комментарий, количество товара, цвет, код.
        /// </summary>
        /// <param name="name">Именование.</param>
        /// <param name="producer">Производитель.</param>
        /// <param name="date">Дата изготовления.</param>
        /// <param name="price">Цена.</param>
        /// <param name="comment">Комментарий.</param>
        /// <param name="count">Количество.</param>
        /// <param name="color">Цвет.</param>
        public CountProduct(string name, string producer, string date, float price, string comment, int count, string color) : base(name, producer, date, price, comment)
        {
            SetCount(count);
            SetColor(color);
            SetCode();
        }

        /// <summary>
        /// Вывод всей информации о товаре.
        /// </summary>
        /// <returns>Вся информация о товаре</returns>
        public override string GetInfo()
        {
            return $"Поштучный товар\n" +
                $" Код: {code}\n" +
                $" Название товара: {name}\n" +
                $" Производитель: {producer}\n" +
                $" Дата изготовления: {date.ToLongDateString()}\n" +
                $" Цена: {price} грн.\n" +
                $" Комментарий: {comment}\n" +
                $" Количество: {count} шт.\n" +
                $" Цвет: {color}\n";
        }

        /// <summary>
        /// Добавить товар.
        /// </summary>
        /// <param name="c">Количество товара поштучно</param>
        public void Add(int c)
        {
            count += c;
        }

        /// <summary>
        /// Добавление записи в журнал.
        /// </summary>
        /// <returns>Запись из журнала.</returns>
        public override string AddToJournal()
        {
            return $"Дата: {DateTime.Now.ToLongDateString()}\n Куплено: {count} шт.\n Стоимость: {count * price} грн.\n";
        }

        /// <summary>
        /// Установить количество поштучно.
        /// </summary>
        /// <param name="NewCount">Новое количетсво.</param>
        private void SetCount(int NewCount) {
            while (NewCount < 0)
            {
                ShowException(new Exception("Число не может быть отрицательным. Повтортите ввод:"));
                while(!int.TryParse(Console.ReadLine(), out NewCount))
                {
                    ShowException(new Exception("Неправильный формат ввода. Повтортите ввод: "));
                }
            }
                this.count = NewCount;
        }

        /// <summary>
        /// Установить цвет.
        /// </summary>
        /// <param name="NewColor">Новый цвет.</param>
        private void SetColor(string NewColor)
        {
            while (NewColor == "")
            {
                ShowException(new Exception("Введено пустое значение для цвета! Повторите снова:"));
                NewColor = Console.ReadLine();
            }
            this.color = NewColor;
        }

        /// <summary>
        /// Установить код товара.
        /// </summary>
        private void SetCode()
        {
            this.code = DataCode++;
        }
    }
}
