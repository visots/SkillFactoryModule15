namespace Task15_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");

            var text = Console.ReadLine();
            var punctuation = new List<char>() { ' ', ',', '.', ';', ':', '!', '?' };

            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Вы ввели пустой текст");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Текст без знаков препинания: ");

            var noPunctuation = text.Except(punctuation).ToArray();

            Console.WriteLine(noPunctuation);
        }
    }
}