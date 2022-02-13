using System;

namespace ClassLibraryProduct
{
    public class WeightProduct : Product
    {
        /// <summary>
        /// Общее колличество товара - вес.
        /// </summary>
        private float weight;
        /// <summary>
        /// Страна производства.
        /// </summary>
        private string manufacturerСountry;
        /// <summary>
        /// Страна поставщика.
        /// </summary>
        private string importingСountry;

        /// <summary>
        /// Конструктор класса товара без параметров.
        /// </summary>

        public WeightProduct(float price)
        {
            this.price = price;
        }

        public WeightProduct() : base()
        {
            SetWeight(0);
            SetManufacturerСountry("Unknown");
            SetImportingСountry("Unknown");
        }

        /// <summary>
        /// Конструктор класса товара с параметрами: именование, цена, вес.
        /// </summary>
        /// <param name="name">Именование.</param>
        /// <param name="price">Цена.</param>
        /// <param name="weight">Вес.</param>
        public WeightProduct(string name, string price, float weight) : base(name, price)
        {
            SetWeight(weight);
            SetManufacturerСountry("Unknown");
            SetImportingСountry("Unknown");
        }

        /// <summary>
        /// Конструктор класса товара с параметрами: именование, производитель, дата изготовления, цена, вес.
        /// </summary>
        /// <param name="name">Именование.</param>
        /// <param name="producer">Производитель.</param>
        /// <param name="date">Дата изготовления.</param>
        /// <param name="price">Цена.</param>
        /// <param name="weight">Вес.</param>
        public WeightProduct(string name, string producer, string date, float price, float weight) : base(name, producer, date, price)
        {
            SetWeight(weight);
            SetManufacturerСountry("Unknown");
            SetImportingСountry("Unknown");
        }

        /// <summary>
        /// Конструктор класса товара с параметрами: именование, производитель, дата изготовления, цена, комментарий, вес, страна производителяя, страна поставщика.
        /// </summary>
        /// <param name="name">Именование.</param>
        /// <param name="producer">Производитель.</param>
        /// <param name="date">Дата изготовления.</param>
        /// <param name="price">Цена.</param>
        /// <param name="comment">Комментарий.</param>
        /// <param name="weight">Вес.</param>
        /// <param name="pCountry">Страна производителя.</param>
        /// <param name="dCountry">Страна поставщика.</param>
        public WeightProduct(string name, string producer, string date, float price, string comment, float weight, string pCountry, string dCountry) : base(name, producer, date, price, comment)
        {
            SetWeight(weight);
            SetManufacturerСountry(pCountry);
            SetImportingСountry(dCountry);
        }

        /// <summary>
        /// Вывод всей информации о товаре.
        /// </summary>
        /// <returns>Вся информация о товаре.</returns>
        public override string GetInfo()
        {
            return $"Весовой товар\n" +
                $" Название товара: {name}\n" +
                $" Производитель: {producer}\n" +
                $" Дата изготовления: {date.ToLongDateString()}\n" +
                $" Цена: {price} грн.\n" +
                $" Комментарий: {comment}\n" +
                $" Вес: {weight} кг.\n" +
                $" Страна производитель: {manufacturerСountry}\n" +
                $" Страна импортёр: {importingСountry}";
        }

        /// <summary>
        /// Добавление записи в журнал.
        /// </summary>
        /// <returns>Запись из журнала.</returns>
        public override string AddToJournal()
        {
            return $"Дата: {DateTime.Now.ToLongDateString()}\n Куплено: {weight} кг.\n Стоимость: {weight * price} грн.\n";
        }

        /// <summary>
        /// Добавление продукта.
        /// </summary>
        /// <param name="addedW">Дополнительный вес продукции.</param>
        public void AddProduct(float addedW)
        {
            weight += addedW;
        }

        /// <summary>
        /// Установить вес.
        /// </summary>
        /// <param name="NewCount">Новое количетсво.</param>
        private void SetWeight(float NewWeight)
        {
            while (NewWeight < 0)
            {
                ShowException(new Exception("Число не может быть отрицательным. Повтортите ввод:"));
                while (!float.TryParse(Console.ReadLine(), out NewWeight))
                {
                    ShowException(new Exception("Неправильный формат ввода.Повтортите ввод: "));
                }
            }
            this.weight = NewWeight;
        }

        /// <summary>
        /// Установить страну производителя.
        /// </summary>
        /// <param name="NewManufacturerСountry">Новая страна производителя.</param>
        private void SetManufacturerСountry(string NewManufacturerСountry)
        {
            while (NewManufacturerСountry == "")
            {
                ShowException(new Exception("Введено пустое значение для страны производителя! Повторите снова:"));
                NewManufacturerСountry = Console.ReadLine();
            }
            this.manufacturerСountry = NewManufacturerСountry;
        }

        /// <summary>
        /// Установить страну импортёра.
        /// </summary>
        /// <param name="NewImportingСountry">Новая страна импортёра.</param>
        private void SetImportingСountry(string NewImportingСountry)
        {
            while (NewImportingСountry == "")
            {
                ShowException(new Exception("Введено пустое значение для страны импортёра! Повторите снова:"));
                NewImportingСountry = Console.ReadLine();
            }
            this.importingСountry = NewImportingСountry;
        }

    }
}

