using System;

namespace ClassLibraryProduct
{
    public abstract class Product : IComparable<Product>
    {
        /// <summary>
        /// Название товара.
        /// </summary>
        protected string name;
        /// <summary>
        /// Изготовитель.
        /// </summary>
        protected string producer;
        /// <summary>
        /// Дата изготовления.
        /// </summary>
        protected DateTime date;
        /// <summary>
        /// Цена за товар или единицу веса.
        /// </summary>
        protected float price;
        /// <summary>
        /// Комментарий.
        /// </summary>
        protected string comment;

        /// <summary>
        /// Конструктор товара без параметров.
        /// </summary>
        public Product()
        {
            name = "unknown";
            producer = "unknown";
            date = DateTime.Now;
            price = 100;        // Цена по умолчанию
            comment = "absent";
        }

        /// <summary>
        /// Конструктор товара с параметрами: именование.
        /// </summary>
        /// <param name="name">Именование.</param>
        public Product(string name) : this()
        {
            SetName(name);
        }

        /// <summary>
        /// Конструктор товара с параметрами: именование, изготовитель.
        /// </summary>
        /// <param name="name">Именование.</param>
        /// <param name="producer">Изготовитель.</param>
        public Product(string name, string producer) : this(name)
        {
            SetProducer(producer);
        }


        /// <summary>
        /// Конструктор товара с параметрами: именование, изготовитель, дата изготовления.
        /// </summary>
        /// <param name="name">Именование.</param>
        /// <param name="producer">Изготовитель.</param>
        /// <param name="date">Дата изготовления.</param>
        public Product(string name, string producer, string date) : this(name, producer)
        {
            SetDate(date);
        }

        /// <summary>
        ///  Конструктор товара с параметрами: именование, изготовитель, дата изготовления, цена.
        ///  /// </summary>
        /// <param name="name">Именование.</param>
        /// <param name="producer">Изготовитель.</param>
        /// <param name="date">Дата изготовления.</param>
        /// <param name="price">Цена.</param>
        public Product(string name, string producer, string date, float price) : this(name, producer, date)
        {
            SetPrice(price);
        }

        /// <summary>
        /// Конструктор товара с параметрами: именование, изготовитель, дата изготовления, цена, комментрий.
        /// </summary>
        /// <param name="name">Именование.</param>
        /// <param name="producer">Изготовитель.</param>
        /// <param name="date">Дата изготовления.</param>
        /// <param name="price">>Цена.</param>
        /// <param name="comment">Комментрий.</param>
        public Product(string name, string producer, string date, float price, string comment) : this(name, producer, date, price)
        {
            SetComment(comment);
        }

        /// <summary>
        /// Общая информация о товаре.
        /// </summary>
        /// <returns>Получение всей информации.</returns>
        public virtual string GetInfo()
        {
            return $"Название товара - {name}, производитель - {producer}, дата изготовления - {date}, цена - {price}, комментарий - {comment}";
        }

        /// <summary>
        /// Вывод исключения.
        /// </summary>
        /// <param name="ex">Исключение.</param>
        protected void ShowException(Exception ex)
        {
            Console.WriteLine(ex);
        }

        /// <summary>
        /// Установить именование товара.
        /// </summary>
        /// <param name="name">Новое именование.</param>
        private void SetName(string name)
        {
        while(name == "")
            {
                ShowException(new Exception("Введено пустое значение для имени! Повторите снова:"));
                name = Console.ReadLine();
            }
            this.name = name;
        }

        /// <summary>
        /// Установить производителя товара.
        /// </summary>
        /// <param name="producer">Новый производитель товара.</param>
        private void SetProducer(string producer)
        {
            while (producer == "")
            {
                ShowException(new Exception("Введено пустое значение для производителя! Повторите снова:"));
                producer = Console.ReadLine();
            }
            this.producer = producer;
        }

        /// <summary>
        /// Установить дату производства товара.
        /// </summary>
        /// <param name="date">Новая дата производства товара.</param>
        private void SetDate(string date)
        {
            while (date == "")
            {
                ShowException(new Exception("Введено пустое значение для даты! Повторите снова:"));
                date = Console.ReadLine();
            }
            DateTime NewDate;
            while (!DateTime.TryParse(date, out NewDate))
            {
                ShowException(new Exception("Неправильный формат даты! Повторите снова:"));
                date = Console.ReadLine();
            }
            this.date = NewDate;
        }

        /// <summary>
        /// Установить цену товара.
        /// </summary>
        /// <param name="NewPrice">Новая цена товара.</param>
        private void SetPrice(float NewPrice)
        {
            while (NewPrice < 0)
            {
                ShowException(new Exception("Цена не может быть отрицательной! Введите снова: "));
                while (!float.TryParse(Console.ReadLine(), out NewPrice))
                {
                    ShowException(new Exception("Неправильный формат числа! Повторите снова:"));
                }
            }
            this.price = NewPrice;
        }

        /// <summary>
        /// Добавление записи в журнал.
        /// </summary>
        /// <returns>Запись из журнала.</returns>
        public virtual string AddToJournal()
        {
          
            return $"Дата: {DateTime.Now}, стоимость товара: {price}грн.\n";
        }


        /// <summary>
        /// Установить комментарий товара.
        /// </summary>
        /// <param name="comment">Новый комментрий товара.</param>
        private void SetComment(string comment) => this.comment = comment;

        public int CompareTo(Product other) => price.CompareTo(other.price);
    }
}