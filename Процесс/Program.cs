using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Процесс.Program;

namespace Процесс
{
    internal static class Program
    {
        class FinancialReport
        {
            static void Main(string[] args)
            {
                string name, expenditure, date;
                double income, expenCost, coffeeCost;
                int cofCount;
                Console.Write("Введите ваше имя для отчета: ");
                name = Console.ReadLine();
                Console.Write("Введите дату для отчета: ");
                date = Console.ReadLine();
                Console.Write("Введите сумму дохода за день: ");
                income = double.Parse(Console.ReadLine());
                Console.Write("Введите основную статью расхода: ");
                expenditure = Console.ReadLine();
                Console.Write("Введите сумму расхода на продукты: ");
                expenCost = double.Parse(Console.ReadLine());
                Console.Write("Введите количество чашек кофе за день: ");
                cofCount = int.Parse(Console.ReadLine());
                Console.Write("Введите стоимость одной чашки кофе: ");
                coffeeCost = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("====================================");
                Console.WriteLine($"\t{name} - Финансовый отчет за {date}");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine("----- ВВЕДЕННЫЕ ДАННЫЕ -----");
                Console.WriteLine();
                Console.WriteLine($"Доход: {income:F2} руб.");
                Console.WriteLine($"Основной расход ({expenditure}): {expenCost} руб.");
                Console.WriteLine($"Количество кофе: {cofCount}");
                Console.WriteLine($"Стоимость одного кофе: {coffeeCost:F2} руб.");
                Console.WriteLine();
                Console.WriteLine("----- РАСЧЕТЫ  -----");
                double expenCoffee = cofCount * coffeeCost;
                double expenAll = expenCost + expenCoffee;
                Console.WriteLine($"Расходы на кофе: {expenCoffee:F2} руб.");
                Console.WriteLine($"Общие расходы: {expenAll:F2} руб.");
                double gain = income - expenAll;
                Console.WriteLine($"Итог за день: {gain:F2} руб.");
                double share = expenCoffee / income * 100;
                Console.WriteLine($"Процент дохода на кофе: {share:F2} %");


            }

        }

    }
}














