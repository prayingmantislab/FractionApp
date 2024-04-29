using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter the first fraction (numerator/denominator): ");
            string[] input1 = Console.ReadLine().Split('/');
            int n1 = int.Parse(input1[0]);
            int d1 = int.Parse(input1[1]);
            Fraction f1 = new Fraction(n1, d1);

            Console.Write("Enter the second fraction (numerator/denominator): ");
            string[] input2 = Console.ReadLine().Split('/');
            int n2 = int.Parse(input2[0]);
            int d2 = int.Parse(input2[1]);
            Fraction f2 = new Fraction(n2, d2);

            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Fraction sum = f1.Add(f2);
                    Console.WriteLine($"{f1} + {f2} = {sum}");
                    break;
                case 2:
                    Fraction difference = f1.Subtract(f2);
                    Console.WriteLine($"{f1} - {f2} = {difference}");
                    break;
                case 3:
                    // Fraction product = f1.Multiply(f2);
                    // Console.WriteLine($"{f1} * {f2} = {product}");
                    break;
                case 4:
                    // Fraction quotient = f1.Divide(f2);
                    // Console.WriteLine($"{f1} / {f2} = {quotient}");
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.WriteLine();
        }
    }
}