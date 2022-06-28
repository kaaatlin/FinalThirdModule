using System;

namespace Exceptions
{
    internal class Program
    {
        enum Days
        {
            понедельник = 1,
            вторник,
            среда,
            четверг,
            пятница,
            суббота,
            воскресенье
        }


        static void Main(string[] args)
        {
            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Ваш возраст: ");
            byte age = checked ((byte)int.Parse(Console.ReadLine()));

            if (age < 18)
            {
                Console.WriteLine("Вас зовут {0} и Вы несовершеннолетний", name);
            }
            else
            {
                Console.WriteLine("Вас зовут {0} и Вы совершеннолетний", name);
            }

            Console.Write("Ваш рост: ");
            double high = double.Parse(Console.ReadLine());
            Console.WriteLine("Ваш рост составляет " + high);

            Console.Write("Какой ваш любимый день недели? ");
            Days FavDay = (Days) int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш любимый день недели " + FavDay);

            Console.ReadKey();
        }
    }
}
