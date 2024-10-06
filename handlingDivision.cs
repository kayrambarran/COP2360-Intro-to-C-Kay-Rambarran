/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();
        
        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();
        
        DivideStrings(input1, input2);
    }

    static void DivideStrings(string str1, string str2)
    {
        try
        {
            int num1 = Convert.ToInt32(str1);
            int num2 = Convert.ToInt32(str2);
            int result = num1 / num2;
            Console.WriteLine($"The result of the division is: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: One of the inputs is not a valid integer.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
    }
}
