// static void Main(string[] args)
// {
//     Console.WindowWidth = 60;
//     Console.WindowHeight = 20;
//     Console.BufferWidth = 60;
//     Console.BufferHeight = 20;

//     while (true)
//     {
//         Console.Clear();
//         Console.ForegroundColor = ConsoleColor.Green;
//         DrawBorder();
//         Console.SetCursorPosition(2, 2);
//         Console.Write("מחשבון שברים");
//         Console.SetCursorPosition(2, 4);
//         Console.ForegroundColor = ConsoleColor.Cyan;
//         Console.Write("הזן מונה לשבר הראשון: ");
//         int n1 = int.Parse(Console.ReadLine());

//         Console.Write("הזן מכנה לשבר הראשון: ");
//         int d1 = int.Parse(Console.ReadLine());

//         Console.ForegroundColor = ConsoleColor.Magenta;
//         Console.Write($"\n\t{n1}/{d1}\n");

//         // ... (קוד דומה להזנת השבר השני והפעולה החשבונית)

//         Fraction f1 = new Fraction(n1, d1);
//         Fraction f2 = new Fraction(n2, d2);

//         Fraction result;
//         switch (op)
//         {
//             case '+':
//                 result = f1.Add(f2);
//                 Console.ForegroundColor = ConsoleColor.Yellow;
//                 Console.Write($"\n\t{f1} + {f2} = {result}\n");
//                 break;
//             // ... (טיפול בפעולות חשבוניות נוספות)
//         }

//         Console.ResetColor();
//         Console.Write("\nלחץ 'x' לצאת או כל מקש אחר להמשיך...");
//         if (Console.ReadKey().Key == ConsoleKey.X)
//             break;
//     }
// }

// static void DrawBorder()
// {
//     Console.ForegroundColor = ConsoleColor.DarkYellow;
//     Console.SetCursorPosition(0, 0);
//     Console.Write("╔═══════════════════════════════════════╗");
//     for (int i = 1; i < 6; i++)
//     {
//         Console.SetCursorPosition(0, i);
//         Console.Write("║");
//         Console.SetCursorPosition(39, i);
//         Console.Write("║");
//     }
//     Console.SetCursorPosition(0, 6);
//     Console.Write("╚═══════════════════════════════════════╝");
// }