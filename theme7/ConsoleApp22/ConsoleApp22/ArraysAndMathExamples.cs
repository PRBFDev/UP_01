using System;
using System.Linq;

namespace ConsoleApp22 {
   public static class ArraysAndMathExamples {
        public static T[] SortUp<T>(this T[] array) {
            Array.Sort(array);
            return array;
        }
        public static T[] SortDown<T>(this T[] array) {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
        public static T[] Merge<T>(this T[] a, T[] b) {
            T[] result = new T[a.Length + b.Length];
            Array.Copy(a, 0, result, 0, a.Length);
            Array.Copy(b, 0, result, a.Length, b.Length);
            return result;
        }
        public static int CalculateDifference(int input) {
            int result = Math.Abs(input - 123);
            if (input > 123) return result * 3;
            return result;
        }
    }
}
