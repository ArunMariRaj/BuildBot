namespace BuildBotTrial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.FirstNumber = 20;
            calculator.SecondNumber = 50;
            System.Console.WriteLine(calculator.Add());
        }
    }
}
