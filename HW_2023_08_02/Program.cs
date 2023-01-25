using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2023_08_02
{
    internal class Program
    {
        enum Week
        {
            Понедельник = 1,
            Вторние,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        };
        static void Main(string[] args)
        {
            /*string[] a = { "Среда", "Четверг", "Понедельник", "Вторник", "Воскресенье", "Суббота", "Пятница" }
            С помощью LINQ вывести все дни недели, названия которых имеют больше 6 букв
            Бонусное задание: С помощью LINQ сделать сортированную выборку, в которой все дни недели будут упорядочены*/
            string[] a = { "Среда", "Четверг", "Понедельник", "Вторник", "Воскресенье", "Суббота", "Пятница" };            
            foreach (string item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Все дни недели, названия которых имеют больше 6 букв\n");
            var res = from p in a
                      let word = p.ToCharArray()
                      where p.Length > 6
                      select p;
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированные дни недели\n");
            var weekRes = from p in Enum.GetNames(typeof(Week))
                          select p;
            foreach (var item in weekRes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
