using System;
using Latypova.AllStruct;

namespace Latypova
{
    class Programm
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("#1");
            Console.WriteLine($"sbyte - {sbyte.MaxValue}-{sbyte.MinValue}");
            Console.WriteLine($"byte - {byte.MaxValue}-{byte.MinValue}");
            Console.WriteLine($"short - {short.MaxValue}-{short.MinValue}");
            Console.WriteLine($"ushort - {ushort.MaxValue}-{ushort.MinValue}");
            Console.WriteLine($"int - {int.MaxValue}-{int.MinValue}");
            Console.WriteLine($"uint - {uint.MaxValue}-{uint.MinValue}");
            Console.WriteLine($"long - {long.MaxValue}-{long.MinValue}");
            Console.WriteLine($"ulong - {ulong.MaxValue}-{ulong.MinValue}");
            Console.WriteLine($"float - {float.MaxValue}-{float.MinValue}");
            Console.WriteLine($"double - {double.MaxValue}-{double.MinValue}");
            Console.WriteLine($"decimal - {decimal.MaxValue}-{decimal.MinValue}");
            //2
            Console.WriteLine("#2");
            Person person = new Person();
            Console.WriteLine($"Введите имя, возраст, город, PIN-код");
            person.name = Console.ReadLine();
            person.age = Convert.ToInt32(Console.ReadLine());
            person.city = Console.ReadLine();
            person.pincode = Convert.ToInt32(Console.ReadLine());
            person.Print();
            //3
            Console.WriteLine("#3");
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string low = str.ToLower();
            string high = str.ToUpper();
            string newstr = "";
            for (int i = 0; i < low.Length; i++)
            {
                if (str[i] == low[i])
                {
                    newstr = newstr + high[i];
                }
                else
                {
                    newstr = newstr + low[i];
                }

            }
            Console.WriteLine(newstr);
            //4
            Console.WriteLine("#4");
            Console.Write("Введите строку: ");
            string str1 = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            string str2 = Console.ReadLine();
            int c = 0;
            for (int i = 0; i <= str1.Length - str2.Length; i++)
            {
                if (str1.Substring(i, str2.Length) == str2)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
            //5
            Console.WriteLine("#5");
            Console.WriteLine("Введите обычную цену бутылки, сколько процентов составляет скидка, а также стоимость отпуска: ");
            int normPrice = int.Parse(Console.ReadLine());
            double salePrice = normPrice - (double.Parse(Console.ReadLine()) * 0.01) * normPrice;
            int holidayPrice = int.Parse(Console.ReadLine());
            double bottlesNeeded = holidayPrice / (normPrice - salePrice);
            Console.WriteLine($"Вам нужно купить {(int)bottlesNeeded} бутылок, чтобы окупить поездку.");

            //6
            Console.WriteLine("#6");
            Students st1 = new Students()
            {
                firstname = "Ozzy",
                lastname = "Osbourne",
                id = 123,
                birthdayDate = "3 декабря 1948",
                alcCategory = "a",
                vol=83
            };
            Students st2 = new Students()
            {
                firstname = "Chester",
                lastname = "Bennington",
                id = 124,
                birthdayDate = "20 марта 1976",
                alcCategory = "b",
                vol = 55
            };
            Students st3 = new Students()
            {
                firstname = "Joey",
                lastname = "Jordison",
                id = 125,
                birthdayDate = "26 апреля 1975",
                alcCategory = "c",
                vol = 46
            };
            Students st4 = new Students()
            {
                firstname = "Kurt",
                lastname = "Cobain",
                id = 126,
                birthdayDate = "4 января 1963",
                alcCategory = "a",
                vol = 27
            };
            Students st5 = new Students()
            {
                firstname = "Freddie",
                lastname = "Mercury",
                id = 127,
                birthdayDate = "5 сентября 1946",
                alcCategory = "d",
                vol = 45
            };
            Students[] group = new Students[5];
            group = [st1, st2, st3, st4, st5];
            Drinks drinks = new Drinks();
            float capacity = 0;
            float alcoholCapcty = 0;
            foreach (Students student in group)
            {
                capacity += student.vol;
            }
            Console.WriteLine($"общий объем выпитого студнтами {capacity}");

            foreach (Students student in group)
            {
                if (student.alcCategory[0] == 'a') { alcoholCapcty += student.vol * drinks.vodka; }
                else if (student.alcCategory[0] == 'b') { alcoholCapcty += student.vol * drinks.jackDaniels; }
                else if (student.alcCategory[0] == 'c') { alcoholCapcty += student.vol * drinks.vino; }
                else if (student.alcCategory[0] == 'd') { alcoholCapcty += student.vol * drinks.limonad; }
            }

            Console.WriteLine($"объем чистого алкоголя, который выпили студенты {alcoholCapcty}\n");
            foreach (Students student in group)
            {
                if (student.alcCategory[0] == 'a') { Console.WriteLine($"{student.firstname} {student.lastname} выпил {alcoholCapcty / (student.vol * drinks.vodka)} процентов всего алкоголя"); }
                else if (student.alcCategory[0] == 'b') { Console.WriteLine($"{student.firstname} {student.lastname} выпил {alcoholCapcty / (student.vol * drinks.jackDaniels)} процентов всего алкоголя"); }
                else if (student.alcCategory[0] == 'c') { Console.WriteLine($"{student.firstname}{student.lastname} выпил {alcoholCapcty / (student.vol * drinks.vino)} процентов всего алкоголя"); }
                else if (student.alcCategory[0] == 'd') { Console.WriteLine($"{student.firstname} {student.lastname} пил лимонад"); }
            }
            Console.WriteLine();
            foreach (Students student in group)
            {
                Console.WriteLine($"{student.firstname} {student.lastname} выпил {capacity / student.vol} процентов от объема выпитого");
            }

        }
    }
}