using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods do stuff, action words, they're verbs
            //Tend to belong to/ interact with an object
            //They have parenthesis afterwards
            //There are built in methods Such as
            //Split, WriteLine, ReadLine
            //Arrays - Reverse, Sort

            //Methods are a tool for us to create reusable pieces of code
            //They create less error prone code
            //They'll never be created inside of anthor method or member of the class
            //Methods are a way to create a series of instructions and then call them when we need them
            //Methods are always a part of a class
            //Methods are always children classes
            //They will never be inside of another method

        }   //Access Modifier Tells us what part of the program is allowed to be access
            //ReturnType After the method is done performing its work, this is the type of information that will be sent back from itself where to whever its being called in the main method
            //MethodName
            //Access Modifier- ReturnType - MethodName( in Pascal Case)- Parenthesis (sometimes with parameters)
            //Parameters function sometimes as temporary variables
            //parameters dont have to have the same reutrn type
            public static int Add(int firstNumber, int secondNumber)
            {
            //Method body
            //A complete method - header and body- is called a method declaration
            //Static means we don't have to worry about objects
            //Methods should only perform one task and that should be the name we have given them
            //The return keyword takes whatever value is determined by using this method and sends that value back to where I call my method
            //If you have a method that does not have a return value, you would use the keyword void. When we have a void return type we DONT need to use the keyword return
            Console.WriteLine("Hello. Please enter the first number to be added");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello. Please enter a second number to be added");
            int number2 = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber; 
            return sum;

            // int answer = Add(5, 7);
            //or
            int answer = Add(number1 + number2);
            Console.WriteLine(answer);

            }
        
    }
}
