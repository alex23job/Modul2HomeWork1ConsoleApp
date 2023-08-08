using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HomeWork1ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Петров Андрей Павлович";
            int age = 38;
            string email = "PetrowAP@mail.ru";
            float programmingScores = 4.9f;
            float mathScores = 4.6f;
            float physicsScores = 4.4f;
            string scorePattern = "{0, -20} : {1:0.00}";
            string scorePatternNewLine = "\n{0, -20} : {1:0.00}";

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Ф.И.О.  : " + fullName);
            Console.WriteLine("Возраст : {0}", age);
            Console.WriteLine("E-mail  : " + email);
            Console.WriteLine(scorePatternNewLine, "Программирование", programmingScores);
            Console.WriteLine(scorePattern, "Математика", mathScores);
            Console.WriteLine(scorePattern, "Физика", physicsScores);

            Console.ReadKey();
        }
    }
}
