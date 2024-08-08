using System;

class Program
{
    public static void Main()
    {
        string[] input = { "hello", "hold" }; //output: false
        bool result = AreAllLettersPresent(input);
        Console.WriteLine(result); 
    }

    public static bool AreAllLettersPresent(string[] strings)
    {
        if (strings.Length != 2)
        {
            throw new ArgumentException("The input array must contain exactly two strings.");
        }

        string first = strings[0];
        string second = strings[1];

        foreach (char c in second)
        {
            if (!first.Contains(c))
            {
                return false;
            }
        }

        return true;
    }
}
