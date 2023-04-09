namespace Task15_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = Factorial(5);
            Console.WriteLine(res);
        }

        static long Factorial(int number)
        {
            int[] nums = new int[number];

            for (int n = 0; n <= number-1; n++)
                nums[n] = n+1;

            long result = nums.Aggregate((x, y) => x * y); ;
            return result;
        }
    }
}