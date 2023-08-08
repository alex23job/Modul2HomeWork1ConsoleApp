using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HomeWork2ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Иванов Дмитрий Сергеевич";
            int age = 47;
            string email = "IvanowDS@mail.ru";
            float programmingScores = 4.7f;
            float mathScores = 4.8f;
            float physicsScores = 4.5f;
            string scorePattern = "{0, -20} : {1:0.00}"; 
            string scorePatternNewLine = "\n{0, -20} : {1:0.00}";

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Ф.И.О.  : " + fullName);
            Console.WriteLine("Возраст : {0}", age);
            Console.WriteLine("E-mail  : " + email);
            Console.WriteLine(scorePatternNewLine, "Программирование", programmingScores);
            Console.WriteLine(scorePattern, "Математика", mathScores);
            Console.WriteLine(scorePattern, "Физика", physicsScores);

            Console.WriteLine("\nНажмите любую клавишу для продолжения ...");
            Console.ReadKey();

            float sumOfBalls = 0;
            float averageScore = 0;

            sumOfBalls = programmingScores + mathScores + physicsScores;
            averageScore = sumOfBalls / 3;

            Console.WriteLine(scorePatternNewLine, "Сумма баллов", sumOfBalls);
            Console.WriteLine(scorePattern, "Средний балл", averageScore);

            Console.WriteLine("\nНажмите \"Enter\" для завершения ...");
            Console.ReadLine();
        }
    }
}
