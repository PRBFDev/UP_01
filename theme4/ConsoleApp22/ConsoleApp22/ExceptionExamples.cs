using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22 {

    public class User
    {
        public string Name { get; set; }
    }


    public static class ExceptionExamples {
        public static void DivideByZero() {
            try {
                int x = 6;
                int b = x / 0;
            }
            catch (DivideByZeroException ex) {
                Console.WriteLine(ex);
            }
        }
        public static void IndexOutOfRange() {
            try {
                int[] massive = new int[8];
                massive[14] = 5;
            }
            catch(IndexOutOfRangeException ex) {
                Console.WriteLine(ex);
            }
        }
        public static void ObjectNull() {
            try {
               User user = null;
                Console.WriteLine(user.Name);
            }
            catch (NullReferenceException ex) {
                Console.WriteLine(ex);
            }
        }
    }
}
