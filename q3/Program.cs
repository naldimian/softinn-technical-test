using System;

public class TriangularNumber
{
    public static void Main(string[] args)
    {
        Console.WriteLine(TriangularNumberSequence(1)); 
        Console.WriteLine(TriangularNumberSequence(2));
        Console.WriteLine(TriangularNumberSequence(3)); 
        Console.WriteLine(TriangularNumberSequence(4)); 
        Console.WriteLine(TriangularNumberSequence(5)); 
        Console.WriteLine(TriangularNumberSequence(6));
    }
    
    public static int TriangularNumberSequence(int n)
    {
        return n * (n + 1) / 2;
    }

    
}
