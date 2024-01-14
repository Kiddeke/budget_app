// See https://aka.ms/new-console-template for more information
// using System.Numerics;

//Console.WriteLine("Monthly Budget");
//double directDepositAmt = 2800 * 2;
//Console.WriteLine($"Direct Deposit: {directDepositAmt}");
//double mortgage = 2400;
//Console.WriteLine($"Mortgage Amt: {mortgage}");
//double monthlyInvesting = 800;
//Console.WriteLine($"Investing Amt: {monthlyInvesting}");
//double moneyLeft = directDepositAmt - mortgage - monthlyInvesting;
//Console.WriteLine($"Leftover: {moneyLeft}");

// Declare variables and then initialize to zero.
double num1 = 0; double num2 = 0; double num3 = 0;
var num1Value = "Expense"; var num2Value = "Expense"; var num3Value = "Expense"; var num4Value = "Expense";

// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number.
Console.WriteLine("Enter Monthly Income");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Type (Income or Expense)");
num1Value = Convert.ToString(Console.ReadLine());


// Ask the user to type the second number.
Console.WriteLine("Enter Monthly Mortgage");
num2 = Convert.ToDouble(Console.ReadLine());

// Ask the user to type the second number.
Console.WriteLine("Enter Monthly Investing");
num3 = Convert.ToDouble(Console.ReadLine());

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your option? ");

// Use a switch statement to do the math.
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Monthly Disposable Income: {num1} + {num2} + {num3} = " + (num1 + num2 + num3));
        break;
    case "s":
        Console.WriteLine($"Monthly Disposable Income: {num1} - {num2} - {num3} = " + (num1 - num2 - num3));
        break;
    case "m":
        Console.WriteLine($"Monthly Disposable Income: {num1} * {num2} * {num3} = " + (num1 * num2 * num3));
        break;
    case "d":
        Console.WriteLine($"Monthly Disposable Income: {num1} / {num2} / {num3} = " + (num1 / num2 / num3));
        break;
}
// Wait for the user to respond before closing.
Console.WriteLine(num1Value);

Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();