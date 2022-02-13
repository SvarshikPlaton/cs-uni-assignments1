/******************************************************/
/*              Лабораторная работа № 7               */
/*               Регулярные выражения	              */
/*                     Задание 2                      */
/*       Выполнил студент гр. 515ст2 Немов Н.Р.       */
/******************************************************/


using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace lb7App02
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) 
            {
                Console.WriteLine("\nПрограмма ищет слово \"cat\" внутри строки:\n" +
                    "/s - проверить все слова, переданные после данного ключа\n" +
                    "/f - \"/f\" и \"имя файла\", проверить все слова в указанном файле\n" +
                    "/e - запрашивать строки у пользователя и выводить результаты проверки;\n" +
                    "     ввод строк завершается, если пользователь ввел строку «end».\n");
                return;
            }

            switch(args[0])
            {
                case "/s":
                        CatContains(string.Join(" ", args.Skip(1)));
                            break;
                case "/f":
                        try
                        {
                            CatContains(File.ReadAllText(args[1]));
                        } 
                        catch (Exception)
                        {
                            Console.WriteLine("Ошибка открытия файла!");
                        }
                        break;
                case "/e":
                        string text = "";
                        while(true)
                        {
                            if (text == "end")
                                return;
                            Console.Write("Введите текст для проверки: ");
                            text = Console.ReadLine();
                            CatContains(text);
                        }
                        break;
            }
        }

        static void CatContains(string word)
        {
            Regex regex = new Regex(@"\b(cat)\b");
            Console.WriteLine($"Строка \"{word}\" {(regex.IsMatch(word)?"имеет":"не имееет")} совпадение!\n");
        }
    }
}


