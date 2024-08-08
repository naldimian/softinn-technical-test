// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program
{
    public static void Main(string[] args)
    {
        string input = "zabcdefghijk";
        ChangeToNextLetter(input);
    }

    public static void ChangeToNextLetter(string input)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] >= 'a' && charArray[i] <= 'z')
            {
                charArray[i] = (char)(charArray[i] == 'z' ? 'a' : charArray[i] + 1);
            }
            else if (charArray[i] >= 'A' && charArray[i] <= 'Z')
            {
                charArray[i] = (char)(charArray[i] == 'Z' ? 'A' : charArray[i] + 1);
            }
        }

        string result = new string(charArray);
        Console.WriteLine(result);
    }
}
