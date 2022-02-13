/******************************************************/
/*              Лабораторная работа № 6               */
/*                Сортировка коллекций	              */
/*                     Задание 4                      */
/*       Выполнил студент гр. 515ст2 Немов Н.Р.       */
/******************************************************/


using ClassLibraryProduct;
using lb6App;
using System.Collections;
using System.Diagnostics;

/// <summary>
/// Цикл для тестирования
/// </summary>
for (; ; )
{
    int amount;
    // Ввод количества элементов
    Console.Write("Введите количество элементов: ");
    while (!int.TryParse(Console.ReadLine(), out amount)||amount<0)
        Console.Write("Значение неверно введено!\nВведите количество элементов: ");

    // коллекция нетипизированная
    ArrayList alis = new ArrayList((int)amount);

    // коллекция типизированная
    List<Product> lis = new List<Product>((int)amount);

    // массив
    Product[] arr = new Product[amount];

    // пользовательская коллекция
    CollectionType<Product> col = new CollectionType<Product>((int)amount);

    Random random = new Random();

    // Заполнить все коллекции случайными данными
    for (int i=0;i<amount;i++)
    {
        var price = (float)random.Next(10, 100);

        arr[i] = new WeightProduct(price);

        alis.Add(new WeightProduct(price));
        lis.Add(new WeightProduct(price));
        col.Add(new WeightProduct(price));
    }

    // Экземпляры для подсчёта всего времени и каждого случая сортировки
    Stopwatch stopWatch = new Stopwatch();
    Stopwatch forEach = new Stopwatch();
   
    Console.WriteLine("Сортировка {0} элементов начата..", amount);

    stopWatch.Start();

    // Выполнение сортировок коллекций

    forEach.Start();
    Array.Sort(arr);
    forEach.Stop();
    Console.WriteLine("Время на сортировку массива: {0} миллисекунд", forEach.ElapsedMilliseconds);
    

    forEach.Restart();
    alis.Sort();
    forEach.Stop();
    Console.WriteLine("Время на сортировку нетипизированной коллекции: {0} миллисекунд", forEach.ElapsedMilliseconds);

    forEach.Restart();
    lis.Sort();
    forEach.Stop();
    Console.WriteLine("Время на сортировку типизированной коллекции: {0} миллисекунд", forEach.ElapsedMilliseconds);

    forEach.Restart();
    col.Sort();
    forEach.Stop();
    Console.WriteLine("Время на сортировку пользовательской коллекции: {0} миллисекунд", forEach.ElapsedMilliseconds);

    stopWatch.Stop();
    Console.WriteLine("Сортировка окончена! Общее затраченное время на все операции: {0} миллисекунд\n", stopWatch.ElapsedMilliseconds);

    Console.ReadLine();
}


