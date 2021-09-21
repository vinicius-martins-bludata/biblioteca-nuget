using System;

namespace Library
{
    public static class Util
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static string Append(string text)
        {
            return $"Hello {text}";
        }
    }
}
