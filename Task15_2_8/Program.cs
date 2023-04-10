namespace Task15_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> values = new List<double>();

            while (true)
            {
                int value = 0;
                if (!Int32.TryParse(Console.ReadLine(), out value))
                    Console.WriteLine("Введите число");
                else
                {
                    values.Add(value);

                    if (values.Count > 0)
                    {
                        Console.WriteLine("Количество чисел: " + values.Count);
                        Console.WriteLine("Сумма чисел: " + values.Sum());
                        Console.WriteLine("Макс.: " + values.Max());
                        Console.WriteLine("Мин.:" + values.Min());
                        Console.WriteLine("Среднее:" + values.Average());
                    }
                }


            }
        }
    }
}