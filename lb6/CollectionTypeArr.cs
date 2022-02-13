/******************************************************/
/*              Лабораторная работа № 6               */
/*           Массив объектов CollectionType	          */
/*                     Задание 3                      */
/*       Выполнил студент гр. 515ст2 Немов Н.Р.       */
/******************************************************/

namespace lb6App
{
    /// <summary>
    /// Пользовательский список массивов.
    /// </summary>
    /// <typeparam name="T">Тип.</typeparam>
    class CollectionTypeArr<T> where T : IComparable
    {
        /// <summary>
        /// Список массивов
        /// </summary>
        public List<CollectionType<T>> arrList = new List<CollectionType<T>>();

        /// <summary>
        /// Нахождение количества коллекций, содержащих указанный элемент.
        /// </summary>
        /// <param name="item">Указанный элемент.</param>
        /// <returns>Количество коллекций.</returns>
        public int CollectionCountWith(T item)
        {
            int count = 0;
            foreach (var collection in arrList) 
                if (collection.Contains(item))
                    count++;
            return count;
        }

        /// <summary>
        /// Нахождение минимальной коллекции, содержащей указанный элемент.
        /// </summary>
        /// <param name="item">Указанный элемент.</param>
        /// <returns>Минимальная коллекция.</returns>
        public CollectionType<T>? MinCollectionWith(T item)
        {
            CollectionType<T>? min = null;
            foreach (var collection in arrList)
                if (collection.Contains(item))
                {
                    if (min == null)
                    {
                        min = collection;
                        continue;
                    }
                    if (collection.Count < min.Count)
                        min = collection;
                }

            return min;
        }
    }
}
