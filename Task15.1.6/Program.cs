namespace Task15_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Мама мыла раму, а папа лежал на диване.";
            char[] except = new char[] { ',', '.', ';', ':', '?', '!' };

            var newText= text.Except(except).ToArray();

            Console.WriteLine(newText);
        }
    }
}