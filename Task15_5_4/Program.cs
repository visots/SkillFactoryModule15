namespace Task15_5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Вася", "Петя", "Даша", "Гриша" };

            var withoutPetya = names.Where(n => n.Contains('а'))/*.ToArray()*/;

            names.Add("Таня");

            Console.WriteLine("Без Пети весело:");
            foreach (var name in withoutPetya)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Всем весело без Пети");
        }
    }
}