using System;

namespace ConsoleApp22 {
  public static class StringExamples {
        public static void Compare() {
            string  a = "aaa";
            string b = "gjhkgj";
            string result = string.Equals(a,b)? "равны" : "неравны";
            Console.WriteLine(result);
        }
        public static void IndexOf() {
            string test = "abcdef";
            int index = test.IndexOf('a');
            Console.WriteLine($"a = {index}");
        }
        public static void Contains() {
            string text = "lolomg";
            bool result = text.Contains("lol");
            string output = result? "Текст содержит lol" : "Текст не содержит lol";
            Console.WriteLine(output);

        }
        public static void True() {
            string a = "b";
            Console.WriteLine(a == "b");
        }
        public static void NotEqualent_False() {
            string a = "b";
            Console.WriteLine(a != "b");
        }
        public static void NotEqualent_True() {
            string a = "c";
            Console.WriteLine(a != "b");
        }
    }
}
