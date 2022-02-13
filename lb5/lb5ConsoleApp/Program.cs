/******************************************************/
/*             Лабораторная работа № 5                */
/*            Класс делегата и 2 класса	              */
/*                    Приложение А                    */
/*       Выполнил студент гр. 515ст2 Немов Н.Р.       */
/******************************************************/



/// <summary>
/// Первый класс
/// </summary>
class class1
{
    /// <summary>
    /// Первый метод первого класса. Выполняется выражение: 1 / e^h.
    /// </summary>
    /// <param name="h">Аргумент h.</param>
    /// <returns>Результат выражения 1 / e^h.</returns>
    public static double Method1(double h) => 1.0 / Math.Pow(Math.E, h);

    /// <summary>
    /// Второй метод первого класса. Выполняется выражение: z / 10.
    /// </summary>
    /// <param name="z">Аргумент z.</param>
    /// <returns>Результат выражения z / 10.</returns>
    public double Method2(double z) => z / 10;
}

/// <summary>
/// Второй класс
/// </summary>
class class2
{
    /// <summary>
    /// Первый метод второго класса. Выполняется выражение: m - 2048.
    /// </summary>
    /// <param name="m">Аргумент m.</param>
    /// <returns>Результат выражения m - 2048.</returns>
    public double Method(double m) => m - 2048;
}

class Program
{
    /// <summary>
    /// Делегат для методов с одним аргументом double.
    /// </summary>
    /// <param name="a">Аргумент методаа</param>
    /// <returns>Метод делегата.</returns>
    delegate double GetDouble(double a);

    static void Main(string[] args)
    {
        GetDouble getDouble = class1.Method1;

        class1 c = new class1();
        getDouble += c.Method2;

        class2 c2 = new class2();
        getDouble += c2.Method;

        var delegates = getDouble.GetInvocationList();

        for (; ; )
        {
            Console.Write("Введите числовое значение: ");
            double x;
            while(!double.TryParse(Console.ReadLine(), out x))
                Console.Write("Неверный формат записи числа\nВведите другое значение: ");

            Console.Write("Выберите один из методов:\n" +
                "1 - 1 / e^h\n" +
                "2 - z / 10\n" +
                "3 - m - 2048\n" +
                "4 - Посчитать все\n");

            int option = Parse(4, "Выбор: ");
            Option(option, x);

            if (option != 4)
            {
                Console.WriteLine(delegates[option-1].DynamicInvoke(x));
            }
            else
            {
                for(int i=0;i< delegates.Length;i++)
                {
                    Option(i+1, x);
                    Console.WriteLine(delegates[i].DynamicInvoke(x));
                }
            }

            Console.ReadKey();
            Console.Clear();
        }
    }

    /// <summary>
    /// Запрос целого числа.
    /// </summary>
    static int Parse(short range, string text)
    {
        short number = -1;
        while (!Enumerable.Range(1, range).Contains(number))
        {
            try
            {
                Console.Write(text);
                number = short.Parse(Console.ReadLine()); 
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат записи числа");
            }
            if (!Enumerable.Range(1, range).Contains(number))
                Console.WriteLine("Неверное значение..");
        }
        return number;
    }

    /// <summary>
    /// Вывод информации о выборе метода.
    /// </summary>
    /// <param name="option">Выбранный метод.</param>
    /// <param name="x">Аргумент метода.</param>
    static void Option(int option, double x)
    {
        switch (option)
        {
            case 1:
                Console.Write("1 / e^{0} = ", x);
                break;
            case 2:
                Console.Write("{0} / 10 = ", x);
                break;
            case 3:
                Console.Write("{0} - 2048 = ", x);
                break;
            case 4:
                Console.WriteLine("Все методы:");
                break;
            default:
                Console.Write("Неверное значение..");
                return;
        }
    }
}

