namespace Task15_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Патефон";
            string word2 = "Магнитафон";

            var count = word1.Intersect(word2).Count();
            Console.WriteLine(count);
        }
    }
}