Console.WriteLine("insert the number: ");
int number = int.Parse(Console.ReadLine());
int num1 = number % 6;
int num2 = number % 48;

if (num1 == 0 && num2 == 0) Console.WriteLine("the number is a multiple of 6 and 48");
else Console.WriteLine("number is not a multiple 6 and 48");