// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Monthly Budget");
double directDepositAmt = 2800 * 2;
Console.WriteLine($"Direct Deposit: {directDepositAmt}");
double mortgage = 2400;
Console.WriteLine($"Mortgage Amt: {mortgage}");
double monthlyInvesting = 800;
Console.WriteLine($"Investing Amt: {monthlyInvesting}");
double moneyLeft = directDepositAmt - mortgage - monthlyInvesting;
Console.WriteLine($"Leftover: {moneyLeft}");
