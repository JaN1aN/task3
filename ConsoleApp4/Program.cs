using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    static void Main()
    {
        Console.WriteLine("Вход");
        string lines = Console.ReadLine();
        int length = lines.Length;
        int midIndex = length / 2;
        Regex newReg = new Regex(@"[^a-z]", RegexOptions.None);
        MatchCollection matches = newReg.Matches(lines);
        string firstHalf = lines.Substring(0, midIndex);
        string secondHalf = lines.Substring(midIndex);
        string result = ReverseString(firstHalf) + ReverseString(secondHalf);
        var revers = ReverseString(lines) + lines;
        var array = lines.ToCharArray();
        var returns = array.Distinct();

        if (matches.Count > 0)
        {
            foreach (Match mat in matches)
            {
                Console.WriteLine(@"Ошибка,недопустимый символ:" + mat.Value);
            }
        }
        else
        {
            if (length % 2 == 0)
            {

                Console.WriteLine($"Выход: {result}");
                foreach (var x in returns)
                {
                    Console.WriteLine("{0} повторяется {1} раз(а)", x, result.Count(c => c == x));
                }
            }
            else
            {
                Console.WriteLine($"Выход: {revers}");
                foreach (var x in returns)
                {
                    Console.WriteLine("{0} повторяется {1} раз(а)", x, revers.Count(c => c == x));
                }
            }
        }
        Console.ReadKey();
    }
}