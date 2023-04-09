namespace Task15_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var average = Average(new int[] { 1, 2, 3,4,5 });
            Console.WriteLine(average);
        }

        static double Average(int[] numbers)
        {
            return numbers.Sum()/(double)numbers.Length;
        }
    }
}