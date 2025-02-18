namespace InOrder
{
    public class Program
    {
        static void Main(string[] args)
        {
            TF_orderCalculator aOrder = new TF_orderCalculator();
            string sentence = Console.ReadLine();
            Console.WriteLine(aOrder.TF_Teller(sentence));
        }
    }
}
