// See https://aka.ms/new-console-template for more information

public class StaticsHelper {
    static void Main(string[] args) {
        
        Console.WriteLine("Podaj ciąg znaków: ");
        string line = Console.ReadLine();
        Console.WriteLine(line);
    }

    static double CalculateAverage(int[] values) {
        return (double)values.Sum() / values.Length;
    }
}

