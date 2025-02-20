using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace Topic_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine(@"which part to run
for topic 4, part 1, type '1'
for topic 4, part 2, type '2'
for topic 4, part 3, type '3'
for topic 4, part 4, type '4'
for topic 4, part 5, type '5'
");
                //yes i know I can use a loop but im not doin all that for some random menu
                string run = Console.ReadLine();
                if (run == "1")
                {
                    //part 1
                    int age = 0;
                    double salary = 0;

                    Console.WriteLine(@"Part 1:
Hello. What is your name?");
                    string name = Console.ReadLine();
                    Console.WriteLine($"Hi, {name}! How old are you?");
                    Int32.TryParse(Console.ReadLine(), out age);
                    Console.WriteLine($"How much do you make per hour, {name}?");
                    double.TryParse(Console.ReadLine(), out salary);
                    Console.WriteLine($"${salary}! I hope that's per hour and not per year!");
                }
                else if (run == "2")
                {
                    //part 2
                    int grade;
                    double average;

                    Console.WriteLine(@"
Part 2:
Please enter the following information so I can sell it for a profit!");
                    Console.WriteLine();
                    Console.Write("First name: ");
                    string first_name = Console.ReadLine();

                    Console.Write("Last name: ");
                    string last_name = Console.ReadLine();

                    Console.Write("Grade (9-12): ");
                    Int32.TryParse(Console.ReadLine(), out grade);

                    Console.Write("student_id: ");
                    string student_id = Console.ReadLine();

                    Console.Write("login: ");
                    string login = Console.ReadLine();

                    Console.Write("average: ");
                    double.TryParse(Console.ReadLine(), out average);

                    Console.WriteLine(@$"Your information:
    Login:      {login}
    ID:         {student_id}
    Name:       {last_name}, {first_name}
    Average:    {average}%
    Grade:      {grade}
");
                }
                else if (run == "3")
                {
                    //part 3
                    int age;

                    Console.WriteLine(@"Part 3:");
                    Console.Write("Hello. What is your name? ");
                    Console.WriteLine();
                    string name = Console.ReadLine();
                    Console.Write($"Hi, {name}! How old are you? ");
                    int.TryParse(Console.ReadLine(), out age);

                    Console.Write($@"
Did you know that in five years you will be {age + 5} years old?
And five years ago you were {age - 5}! Imagine that!");
                }
                else if (run == "4")
                {
                    //part 4
                    double input;
                    double output = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"provide number {i + 1}");
                        double.TryParse(Console.ReadLine(), out input);
                        output = output + input;

                    }
                    output = output / 2;
                    Console.WriteLine($"result: {output}");
                }

                else if (run == "5")
                {
                    //part 4
                    double double_item_1;
                    double double_item_2;

                    Console.Write("Item 1 name: ");
                    string str_item_1 = Console.ReadLine();

                    Console.Write("Item 1 price: ");
                    double.TryParse(Console.ReadLine(), out double_item_1);

                    Console.Write("Item 2 name: ");
                    string str_item_2 = Console.ReadLine();

                    Console.Write("Item 2 price: ");
                    double.TryParse(Console.ReadLine(), out double_item_2);

                    double total = double_item_1 + double_item_2;
                    double discount = total * 0.2;
                    double sub_total = total - discount;
                    double tax = total * 0.13;
                    double amount_owed = sub_total + tax;

                    Console.WriteLine(@$"
Sales Receipt
Item 1: {str_item_1}
Price: ${double_item_1}
Item 2: {str_item_2}
Price: ${double_item_2}
=====================
Total: ${total}
Discount (20%): ${discount}
Subtotal: ${sub_total}
Tax (13%): ${total}
=====================
Total Owed: $ {amount_owed}
");
                }
                Console.WriteLine("");
                Console.Write("press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
