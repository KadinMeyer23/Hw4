//Kadin Meyer 2/18/2025

namespace Word_Counter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Count acount = new Count();
            string sentence = Console.ReadLine();
            Console.WriteLine(acount.word_count(sentence));
        }
    }
}
