/******************************************************/
/*              Лабораторная работа № 6               */
/*            Пользовательская коллекция	          */
/*                     Задание 1                      */
/*       Выполнил студент гр. 515ст2 Немов Н.Р.       */
/******************************************************/

namespace lb6App
{

    /// <summary>
    /// Пользовательская коллекция.
    /// </summary>
    /// <typeparam name="T">Тип.</typeparam>
    class CollectionType<T> where T : IComparable
    {
        List<T> collection = new List<T>();
        /// <summary>
        /// Своство длинны.
        /// </summary>
        public int Count => collection.Count;
        /// <summary>
        /// Конструктор коллекции
        /// </summary>
        /// <param name="capacity">Объем колекции.</param>
        public CollectionType(int capacity) => collection.Capacity = capacity;

        /// <summary>
        /// Конструктор колекции, позволяющий ее заполнить одиним элементом некоторое количество раз.
        /// </summary>
        /// <param name="count">Количество.</param>
        /// <param name="element">Элемент.</param>
        public CollectionType(int count, T element)
        {
            for (int i = 0; i < count; i++)
                collection.Add(element);
        }

        /// <summary>
        /// Конструктор позволяющий при инициализации добавить коллекцию. 
        /// </summary>
        /// <param name="other">Другая коллекция</param>
        public CollectionType(IEnumerable<T> other)
        {
            collection.Capacity = other.Count();

            foreach (var item in other)
                collection.Add(item);
        }

        /// <summary>
        /// Добавить элемент в коллекциию.
        /// </summary>
        /// <param name="item">Вставляемый элемент в коллекцию.</param>
        public void Add(T item) => collection.Add(item);
        /// <summary>
        /// Убрать элемент из коллекции.
        /// </summary>
        /// <param name="item">Убираемый элемент из коллекции.</param>
        public void Remove(T item) => collection.Remove(item);
        /// <summary>
        /// Проверка хранится ли элемент в коллекции
        /// </summary>
        /// <param name="item">Элемент, что будет проверятся.</param>
        /// <returns>Результат поиска.</returns>
        public bool Contains(T item) => GetIndex(item) != -1;

        /// <summary>
        /// Возврат индекса искомого элемента в коллекции.
        /// </summary>
        /// <param name="item">Элемент, для которого будет проводиться поиск.</param>
        /// <returns>Возврат индекса.</returns>
        public int GetIndex(T item)
        {
            for (int i=0;i<collection.Count;i++)
                if (collection[i].Equals(item))
                    return i;
            return -1;
        }

        /// <summary>
        /// Сортировка коллекции.
        /// </summary>
        public void Sort() => collection.Sort();
    }
}
