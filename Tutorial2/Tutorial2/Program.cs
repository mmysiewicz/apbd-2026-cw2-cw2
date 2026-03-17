// See https://aka.ms/new-console-template for more information

public class StaticsHelper {
    static void Main(string[] args) {
        
        Console.WriteLine("Podaj ciąg znaków: ");
        string line = Console.ReadLine();
        Console.WriteLine(line);
    }

    static double CalculateAverage(int[] values)
    {
        double average = (double)values.Sum() / values.Length;
        Console.WriteLine(average);
        return average;
        
    }

    static int CalculateMax(int[] values)
    {
        return values.Max();
    }

    static int CalculateMin(int[] values)
    {
        return values.Min();
    }
}

