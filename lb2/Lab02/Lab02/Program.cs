/******************************************************/
/*               Лабораторная работа № 2              */
/*      Абстрактные сущности и связи между ними       */
/*                      Задание 1                     */
/*       Выполнил студент гр. 515ст2 Немов Н.Р.       */
/******************************************************/

using System.Data;
using HomeAppliances;


namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Watch> watches = new List<Watch>();
            int indx = -1;
            for (; ; ) 
                Interface();
            

            void Interface() {   
                    Console.WriteLine("Current number of watches: " + watches.Count.ToString());
                Console.WriteLine("\n" +
                    "1 - Add new watch and set up.\n" +
                    "2 - Set up.\n" +
                    "3 - Show all statuses of watches.\n" +
                    "4 - Delete.\n" +
                    "5 - Close the program." +
                    "\n\nChoose: ");

                Int32.TryParse(Console.ReadLine(), out int n);
                Console.Clear();
                switch (n) {
                 case 1:
                        AddNew();
                        break;
                 case 2:
                        Console.WriteLine("Select watch number: ");
                        Int32.TryParse(Console.ReadLine(), out int num);
                        if (watches.ElementAtOrDefault(num-1)!=null)
                            SetUp(num-1);
                        else
                            Console.WriteLine("We don`t have watches!");
                        Console.ReadLine();
                        break;
                 case 3:
                        foreach(var wth in watches)
                            Console.WriteLine(wth.GetStatus() + "\n");
                        Console.ReadLine();
                        break;
                 case 4:
                        Console.WriteLine("Select watch number: ");
                        Int32.TryParse(Console.ReadLine(), out int delnum);
                        if (watches.ElementAtOrDefault(delnum-1) != null)
                            watches.Remove(watches[delnum-1]);
                        else
                            Console.WriteLine("We don`t have watches!");
                        Console.ReadLine();
                        break;
                 case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
       
                }
                Console.Clear();
            }

            void AddNew() {
                Console.WriteLine("Enter watch brand: ");
                string brand = Console.ReadLine();
                Console.WriteLine("Enter watch model: ");
                string model = Console.ReadLine();

                Watch clock;
                if (brand != "" && model != "")
                    clock = new Watch(brand, model);
                else if (brand != "")
                    clock = new Watch(brand);
                else 
                    clock = new Watch();
                watches.Add(clock);
                indx = watches.IndexOf(clock);
                SetUp(indx);
            }

            void SetUp(int indx) {
                for (; ; ) {
                    Console.Clear();

                    Console.WriteLine(watches[indx].GetStatus() + 
                    "\n\n1 - On/Off power.\n" +
                    "2 - On/Off alarm state (Needs power)\n" +
                    "3 - On/Off backlight (Needs power)\n" +
                    "4 - Configure timezone (Needs power)\n" +
                    "5 - Set time. (Needs power)\n" +
                    "6 - Set alarm time (Needs power and on alarm state)\n" +
                    "7 - Back to main menu" +
                    "\n\nChoose: ");

                    Int32.TryParse(Console.ReadLine(), out int n);
                    switch (n) {
                        case 1:
                            watches[indx].TurnPower();
                            break;
                        case 2:
                            watches[indx].TurnAlarmWatch();
                            break;
                        case 3:
                            watches[indx].TurnBacklight();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Select your time zone:\n" +
                                "0  - East America\n" +
                                "1  - West Europe\n" +
                                "2  - East Europe\n" +
                                "3  - West Russia\n" +
                                "4  - Pakistan\n" +
                                "5  - India\n" +
                                "6  - China\n" +
                                "7  - Japan\n" +
                                "8  - Australia\n" +
                                "9  - New Zealand\n" +
                                "10 - Pacific Ocean\n" +
                                "11 - West America" +
                                "\n\nChoose: ");
                            Int32.TryParse(Console.ReadLine(), out int geoindex);
                            watches[indx].SetGeo((GeoTime)geoindex);
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Set time (dd.mm.yyyy hh:mm:ss): ");
                            watches[indx].SetTime(Console.ReadLine());
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Set alarm time (dd.mm.yyyy hh:mm:ss): ");
                            watches[indx].SetAlarm(Console.ReadLine());
                            break;
                        case 7:
                            return;
                        default:
                            Console.WriteLine("Wrong choice!");
                            break;
                    }
                }
            }
        }
    }
}