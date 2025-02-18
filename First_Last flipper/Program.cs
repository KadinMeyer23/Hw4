namespace First_Last_flipper
{
    public class Program
    {
        static void Main(string[] args)
        {
            chars_flipper aflipper = new chars_flipper();
            string sentence = Console.ReadLine();
            Console.WriteLine(aflipper.flipper(sentence));
        }
    }
}
