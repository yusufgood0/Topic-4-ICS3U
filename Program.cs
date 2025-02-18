namespace Topic_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}! How old are you?");
            int age = 0;
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine($"How much do you make per hour, {name}?");
            double salary = 0;
            double.TryParse(Console.ReadLine(), out salary);
            Console.WriteLine($"${salary}! I hope that's per hour and not per year!");

        }
    }
}
