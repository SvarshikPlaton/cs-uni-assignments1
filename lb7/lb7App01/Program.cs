/******************************************************/
/*              Лабораторная работа № 7               */
/*           Сериализация и десериализация 	          */
/*                     Задание 1                      */
/*       Выполнил студент гр. 515ст2 Немов Н.Р.       */
/******************************************************/


using lb7App01;
using Newtonsoft.Json;
using System.Net;
using System.Runtime.Serialization;
using System.Text.Json;

var json = new WebClient().DownloadString("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json");
Console.OutputEncoding = System.Text.Encoding.UTF8;
List<Currency> currencies =  new List<Currency>();
fromFileCurrencies();


for (; ; )
{
    Console.Clear();
    Console.Write("Выбор меню:\n" +
        "0 - Парсинг с сайта\n" +
        "1 - Добавление новой записи в коллекцию\n" +
        "2 - Удаление записи из коллекции\n" +
        "3 - Просмотр всех записей\n" +
        "4 - Изменение любой записи\n" +
        "5 - Поиск записей по любому из полей\n" +
        "6 - Экспорт любой записи в текстовый файл\n" +
        "7 - Выход\n" +
        "\n" +
        "Выбор: ");


    uint choice;
    while (!uint.TryParse(Console.ReadLine(), out choice) || choice > 7)
        Console.WriteLine("Значение неверно введено! Введите снова: ");

    Console.Clear();
    switch (choice)
    {
        case 0:
            {
                var rates = System.Text.Json.JsonSerializer.Deserialize<List<Currency>>(json);

                var indices = new HashSet<int>(currencies.Select(c => c.Index));

                Console.WriteLine("Парсинг с сайта:");
                foreach (var rate in rates)
                    if (!indices.Contains(rate.Index))
                    {
                        currencies.Add(rate);
                        PrintInfo(rate);
                    }
                Console.WriteLine("\nПарсинг завершен..");
                break;
            }
        case 1:
            {
                Console.Write("Создание нового экземпляра..\n" +
                    "Введите индекс: ");
                int index;
                var indices = new HashSet<int>(currencies.Select(c => c.Index));
                while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || indices.Contains(index))
                    Console.Write("Значение неверно введено или такой индекс уже есть!\nВведите снова: ");

                Console.Write("Введите название валюты: ");
                string name = Console.ReadLine();

                Console.Write("Введите курс валюты: ");
                double rate;
                while (!double.TryParse(Console.ReadLine(), out rate) || rate < 0)
                    Console.Write("Значение неверно введено!\nВведите снова: ");

                string date = DateTime.Now.ToShortDateString();

                currencies.Add(new Currency()
                {
                    Index = index,
                    Name = name,
                    Rate = rate,
                    Date = date
                });

                Console.WriteLine("\nВалюта внесена:");
                PrintInfo(currencies[currencies.Count - 1]);
                break;
            }
        case 2:
            {
                if (currencies.Count == 0)
                {
                    Console.WriteLine("\nФункция недоступна, поскольку список пуст!");
                    break;
                }
                var indices = new HashSet<int>(currencies.Select(c => c.Index));
                Console.Write("Введите индекс удаляемой записи о валюте: ");

                int index;
                while (!int.TryParse(Console.ReadLine(), out index) || !indices.Contains(index))
                    Console.Write("Значение неверно введено или такого индекса не существует!\nВведите снова: ");

                for (int i = 0; i < currencies.Count; i++)
                    if (currencies[i].Index == index)
                    {
                        PrintInfo(currencies[i]);
                        currencies.RemoveAt(i);
                        
                    }
                Console.WriteLine("\nЭта запись была удалена..");
                break;
            }
        case 3:
            Console.WriteLine("Все записи :");
            if (currencies.Count == 0)
                Console.WriteLine("Пусто :(");
            else
            {
                foreach (var current in currencies)
                    PrintInfo(current);
            }
            break;
        case 4:
            {
                if (currencies.Count == 0)
                {
                    Console.WriteLine("\nФункция недоступна, поскольку список пуст!");
                    break;
                }
                Console.Write("Введите индекс записи о валюте: ");

                var indices = new HashSet<int>(currencies.Select(c => c.Index));
                int index;
                while (!int.TryParse(Console.ReadLine(), out index) || !indices.Contains(index))
                    Console.Write("Значение неверно введено или такого индекса не существует!\nВведите снова: ");

                Set(index);
            }
            break;
        case 5:
            if (currencies.Count == 0)
            {
                Console.WriteLine("\nФункция недоступна, поскольку список пуст!");
                break;
            }
            Find();
            break;
        case 6:
            {
                if (currencies.Count == 0)
                {
                    Console.WriteLine("\nФункция недоступна, поскольку список пуст!");
                    break;
                }

                Console.Write("Введите название файла для сохранения:");
                string fileName = Console.ReadLine();
                Console.WriteLine("Файл будет сохранен под названием \"{0}.json\"", fileName);
                Console.Write("Желаете сохранить в файл:\n" +
                    "0 - Один экземпляр записи\n" +
                    "1 - Весь список сохранённых записей\n" +
                    "\n" +
                    "Выбор: \n");

                uint fileChoice;
                while (!uint.TryParse(Console.ReadLine(), out fileChoice) || fileChoice > 2)
                    Console.WriteLine("Значение неверно введено! Введите снова: ");

                var saveList = new List<Currency>();
                if (fileChoice == 0)
                {
                    var indices = new HashSet<int>(currencies.Select(c => c.Index));

                    Console.Write("\nВведите индекс записи о валюте: ");
                    int index;
                    while (!int.TryParse(Console.ReadLine(), out index) || !indices.Contains(index))
                        Console.Write("Значение неверно введено или такого индекса не существует!\nВведите снова: ");

                    foreach (var c in currencies)
                        if (c.Index == index) 
                        {
                            saveList.Add(c);
                        }
                }
                else
                {
                    saveList = currencies;
                    toFileCurrencies(saveList, fileName);
                }
                Console.WriteLine("Файл сохранен!");
            }
            break;
        case 7:
            toFileCurrencies(currencies, "info");
            Environment.Exit(0);
            break;
    }
    Console.ReadKey();
}

void Set(int index)
{
    Console.Clear();
    foreach (var c in currencies)
        if (c.Index == index)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("Запись о валюте:");
                PrintInfo(c);
                Console.Write("\nИзменение записи о валюте:\n" +
                    "0 - Индекс\n" +
                    "1 - Название\n" +
                    "2 - Курс\n" +
                    "3 - Обновить время записи\n" +
                    "4 - Выйти из меню\n" +
                    "\n" +
                    "Выбор: ");

                uint choice;
                while (!uint.TryParse(Console.ReadLine(), out choice) || choice > 4)
                    Console.WriteLine("Значение неверно введено! Введите снова: ");

                switch(choice)
                {
                    case 0:
                        {
                            Console.Write("\nВведите новый индекс: ");
                            int newIndex;
                            var indices = new HashSet<int>(currencies.Select(c => c.Index));
                            while (!int.TryParse(Console.ReadLine(), out newIndex) || newIndex < 0 || indices.Contains(newIndex))
                                Console.Write("Значение неверно введено или такой индекс уже есть!\nВведите снова: ");
                          
                            c.Index = newIndex;
                            break;
                        }
                    case 1:
                        {
                            Console.Write("\nВведите новое название валюты: ");
                           
                            c.Name = Console.ReadLine();
                        break;
                        }
                    case 2:
                        {
                            Console.Write("\nВведите курс валюты: ");
                            double rate;
                            while (!double.TryParse(Console.ReadLine(), out rate) || rate < 0)
                                Console.Write("Значение неверно введено!\nВведите снова: ");
                            
                            c.Rate = rate;
                            break;
                        }
                    case 3:
                        {
                            c.Date = DateTime.Now.ToShortDateString();
                            break;
                        }
                    case 4:
                        return;

                }
                Console.WriteLine("\nДанные обновлены!");
                Console.ReadKey();
            }
        }
}

void Find()
{
    for(; ; )
    {
        Console.Clear();
        Console.Write("Введите параметр для поиска валюты:\n" +
            "0 - Индекс\n" +
            "1 - Название\n" +
            "2 - Курс\n" +
            "3 - Время записи\n" +
            "4 - Выйти из меню\n" +
            "\n" +
            "Выбор: ");

        uint choice;
        while (!uint.TryParse(Console.ReadLine(), out choice) || choice > 4)
            Console.WriteLine("Значение неверно введено! Введите снова: ");

        switch(choice)
        {
            case 0:
                Console.Write("\nВведите индекс для поиска: ");
                int index;
                while (!int.TryParse(Console.ReadLine(), out index))
                    Console.Write("Значение неверно введено!\nВведите снова: ");
                Console.WriteLine("Результат поиска: ");
               
                foreach(var currency in currencies)
                    if (currency.Index == index)
                        PrintInfo(currency);
                break;
            case 1:
                Console.Write("\nВведите название валюты для поиска: ");
                string name = Console.ReadLine();
                
                foreach (var currency in currencies)
                    if (currency.Name == name) 
                        PrintInfo(currency);
                break;
            case 2:
                Console.Write("\nВведите курс валюты для поиска: ");
                double rate;
                while (!double.TryParse(Console.ReadLine(), out rate) || rate < 0)
                    Console.Write("Значение неверно введено!\nВведите снова: ");

                foreach (var currency in currencies)
                    if (currency.Rate == rate)
                        PrintInfo(currency);
                break;
            case 3:
                Console.Write("\nВведите дату для поиска: ");
                string date = Console.ReadLine();
                
                foreach (var currency in currencies)
                    if (currency.Date == date)
                        PrintInfo(currency);
                break;
            case 4:
                return;
        }
        Console.WriteLine("\nПоиск окончен!");
        Console.ReadKey();
    }
}

void PrintInfo(Currency currency)
{
    Console.WriteLine($"Индекс: {currency.Index}");
    Console.WriteLine($"Название: {currency.Name}");
    Console.WriteLine($"Курс: {currency.Rate}");
    Console.WriteLine($"Время обновления: {currency.Date}");
    Console.WriteLine(new string('-', 10));
}

void toFileCurrencies(List<Currency> currencies, string fileName)
{
    var options = new JsonSerializerOptions
    {
        WriteIndented = true
    };
    string file = fileName + ".json";
    FileStream FS = File.Open(file, FileMode.OpenOrCreate, FileAccess.Write);
    FS.Position = FS.Length;
    System.Text.Json.JsonSerializer.Serialize(FS, currencies, options);
    FS.Close();
}

void fromFileCurrencies()
{
    string fileName = "info.json";
    if (File.Exists(fileName))
    {
        var res = System.Text.Json.JsonSerializer.Deserialize<List<Currency>>(File.ReadAllText(fileName));
        foreach(var r in res)
        {
            PrintInfo(r);
            currencies.Add(r);
        }
        Console.WriteLine("\nФайл о записях загружен!");
        Console.ReadKey();
        Console.Clear();
    }
}