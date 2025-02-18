//Kadin Meyer
//2/18/2025

namespace AlphabetUpgrader
{
    public class Program
    {
        static void Main(string[] args)
        {
            AlphaUpgrade upgrade = new AlphaUpgrade();
            string sentence = Console.ReadLine();
            Console.WriteLine(upgrade.Alpha_Upgrader(sentence));
        }
    }
}
