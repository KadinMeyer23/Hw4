//Kadin Meyer
//2/18/2025

namespace nvowelcounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            VowCount aCount = new VowCount();
            string sentence = Console.ReadLine();
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( aCount.find_vowels(sentence, count));
        }
    }
}
