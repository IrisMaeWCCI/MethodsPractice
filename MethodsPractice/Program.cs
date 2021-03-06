﻿using System;
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
            Console.WriteLine("Hello. Please enter the first number to be added");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello. Please enter a second number to be added");
            int number2 = int.Parse(Console.ReadLine());

            int answer = Add(number1, number2);
            Console.WriteLine(answer);

            RobotWarning("Will Robinson");
            Useless();
            string myBirthMonth = "September";
            string myFriendBirthMonth = "December";
            string myVehicle = Vehicle(myBirthMonth);
            string myFriendVehicle = Vehicle(myFriendBirthMonth);
            Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle {1}.", myVehicle, myFriendVehicle);

            Console.WriteLine("Please enter a name");
            string theName = Console.ReadLine();
            Console.WriteLine("Please enter food");
            string theFood = Console.ReadLine();
            FavoriteFood(theName, theFood);
            Console.WriteLine();

            RetirementCalculator(age);
            Console.WriteLine("Please enter an age");
            int age = int.Parse(Console.ReadLine());
            int retirementAge = 65;
            Console.WriteLine("The user will retire in " + retirementAge + "years");

            double hoursWorked = 42.3d;
            double hourlyWage = 12.50d;

            WageCalculator(hoursWorked,hourlyWage)
             Console.WriteLine("Your monthly wage is{0}.", WageCalculator(hoursWorked, hourlyWage));
            //you dont have to use the same variable names from class to class, but you totally can if you want
            //user input all goes inside of the main method
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
            int sum = firstNumber + secondNumber;
            return sum;
            //int answer = Add(number1 + number2);

        }
        public static void RobotWarning (string name)
        {
            Console.WriteLine("Danger, " + name + "!!");
        }
        public static void Useless()
        {
            Console.WriteLine("Blah blah blah");
        }
        public static string Vehicle(string birthMonth)
        {
            string vehicleFortune;
            if (birthMonth.ToUpper()=="SEPTEMBER"|| birthMonth.ToUpper() == "OCTOBER")
            {
                vehicleFortune = "Hoverboard";

            }
            else
            {
                vehicleFortune = "SUV";
            }
            return vehicleFortune;

        }
        public static void FavoriteFood(string name, string food)
        {
           
            Console.WriteLine(name+"'s favorite food is " +food+"!");
        }
        public static int RetirementCalculator(int age)
        {
             
            int userAge = int.Parse(Console.ReadLine());
            int retirementAge = 65- userAge;
            Console.WriteLine("The user will retire in " + retirementAge + "years");
            
        }
        public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
        {
            //This method should calculate the MONTHLY wage
            double monthlyWage = (hoursWorkedWeekly * 52 * hourlyWage) / 12;//this should provided us with our average monthly calculation

            return monthlyWage;
        }
    }
}
