Console.WriteLine("enter a five-digit number");

int number = int.Parse(Console.ReadLine());

int firstDigit = number / 10000;
int secondDigit = (number - firstDigit * 10000 ) / 10000;
int thirdDigit = (number - firstDigit * 10000 - secondDigit * 1000) / 100;
int fourthDigit = (number - firstDigit * 10000 - secondDigit * 1000 - thirdDigit * 100) / 10;
int fifthDigit = number - firstDigit * 10000 - secondDigit * 1000 - thirdDigit * 100 - fourthDigit * 10;

if(firstDigit == firstDigit && secondDigit == fourthDigit)
          Console.WriteLine("you entered a palindrome!");
else
          Console.WriteLine("number is not a palindrome!");
    


