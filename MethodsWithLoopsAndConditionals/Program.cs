using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintThousand();
            // PrintByThree();
            //Console.WriteLine(IsEqual(2, 3));
            //CheckEvenOrOdd(5);
            //CheckPosOrNeg(-3);
            //OfVotingAge(16);
            //Range(-12);
            MultTable();
        }

        //1. Write a method that will print
        //to the console all numbers 1000 through -1000.
        public static void PrintThousand ()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //2. Write a method that will print
        //to the console numbers 3 through 999 by 3 each time
        public static void PrintByThree()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        //3. Write a method to accept two integers as parameters
        //and check whether they are equal or not.
        public static bool IsEqual (int a, int b)
        {
            var check = (a == b) ? true : false;
            
            return check;
        }

        //4. Write a method to check whether
        //a given number is even or odd.
        public static void CheckEvenOrOdd(int c)
        {
            var EvenOrOdd = (c % 2 == 0)? $"{c} is even!" : $"{c} is odd!";
            Console.WriteLine(EvenOrOdd);  
        }

        //5. Write a method to check whether
        //a given number is positive or negative.
        public static void CheckPosOrNeg (int g)
        {
            var PosOrNeg = (g > 0) ? $"{g} is positive!" : $"{g} is negative!";
            Console.WriteLine(PosOrNeg);
        }

        //6. Write a method to read
        //the age of a candidate and
        //determine whether they can vote.
        //Hint: use Parse()... or the safer TryParse() for an extra challenge!!
        public static bool OfVotingAge (int age)
        {               
            if (age >= 18)
            {
                Console.WriteLine("Yes they are of voting age");
                return true;
            }
            else
                Console.WriteLine($"Too young to vote by {18 - age} years");
            return false;
        }

        //Heatin up #1:
        //Write a method to check if an integer(from the user) is in the range -10 to 10.
        public static bool Range (int num)
        {
            if (num <=10 && num >= -10)
            {
                Console.WriteLine($"{num} is in the range -10 to 10");
                return true;
            }
            Console.WriteLine($"{num} is outside the range -10 to 10");
            return false;
        }

        //Heatin up #2:
        //Write a method to display
        //the multiplication table(from 1 to 12) of a given integer.
        public static void MultTable ()
        {
            int number, multiplier;
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());
            
            for (multiplier = 1; multiplier <=12; multiplier++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, multiplier, (number * multiplier));
            }
        }

    }






}
