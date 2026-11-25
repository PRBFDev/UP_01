using System;
using System.Text;

namespace ConsoleApp22 {
    internal class Program {
        static void Main(string[] args) {
            int[] a = { 1, 2, 3, 4, 5};
            int[] b = { 14, 52, 43, 34, 25};
            StringBuilder sb1 = new StringBuilder();
            sb1.AppendLine("Возрастание:");
            sb1.AppendLine(string.Join(" ",a.SortUp()));
            sb1.AppendLine("Убывание:");
            sb1.AppendLine(string.Join(" ", b.SortUp()));
            sb1.AppendLine("Объединение:");
            sb1.AppendLine(string.Join(" ", a.Merge(b)));
            Console.WriteLine(sb1.ToString());
            if (int.TryParse(Console.ReadLine(),out int input)) {
                Console.WriteLine($"Разница:{ArraysAndMathExamples.CalculateDifference(input)}");
            }
        }
    }
}
