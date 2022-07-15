using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string day;
            Console.Write("Напишите любой день недели или exit чтобы завершить: ");
            day = Console.ReadLine();

            while (day == "exit")
            {
                Console.WriteLine("Выход из программы");
                break;
            }

            switch (day)
                {
                    case "понедельник":
                    case "вторник":
                    case "среда":
                    case "четверг":
                    case "пятница":
                    case "суббота":
                    case "воскресенье":
                        Console.WriteLine("день недели");
                        break;
                    default:
                        Console.WriteLine("Я такого дня недели не знаю");
                    break;
                }
        }
        }
    }
    

