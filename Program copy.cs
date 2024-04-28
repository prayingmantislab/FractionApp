// using System;

// class Program
// {
//   static void Main()
//   {
//     while (true)
//     {
//       Console.Write("Enter the first fraction (numerator/denominator): ");
//       string? line = Console.ReadLine();
//       Fraction? f1 = null;
//       if (line != null)
//       {
//         string[] input1 = line.Split('/');
//         int n1 = int.Parse(input1[0]);
//         int d1 = int.Parse(input1[1]);
//         f1 = new Fraction(n1, d1);
//       }
//       else
//       {
//         Console.WriteLine("Invalid input. Please enter a fraction in the format numerator/denominator.");
//         continue;
//       }

//       Console.Write("Enter the second fraction (numerator/denominator): ");
//       line = Console.ReadLine();
//       Fraction? f2 = null;
//       if (line != null)
//       {
//         string[] input2 = line.Split('/');
//         int n2 = int.Parse(input2[0]);
//         int d2 = int.Parse(input2[1]);
//         f2 = new Fraction(n2, d2);
//       }
//       else
//       {
//         Console.WriteLine("Invalid input. Please enter a fraction in the format numerator/denominator.");
//         continue;
//       }

//       Console.WriteLine("\nChoose an operation:");
//       Console.WriteLine("1. Addition");
//       Console.WriteLine("2. Subtraction");
//       Console.WriteLine("3. Multiplication");
//       Console.WriteLine("4. Division");
//       Console.WriteLine("5. Exit");

//       int choice;
//       if (line != null)
//       {
//         choice = int.Parse(line);
//       }
//       else
//       {
//         Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
//         continue;
//       }

//       switch (choice)
//       {
//         case 1:
//           Fraction sum = f1.Add(f2);
//           Console.WriteLine($"{f1} + {f2} = {sum}");
//           break;
//         case 2:
//           // Implement subtraction
//           break;
//         case 3:
//           // Implement multiplication
//           break;
//         case 4:
//           // Implement division
//           break;
//         case 5:
//           return;
//         default:
//           Console.WriteLine("Invalid choice!");
//           break;
//       }

//       Console.WriteLine();
//     }
//   }
// }