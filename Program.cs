using System;
using System.Security.Cryptography;
namespace Linq
{

    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); // we created the list
            Random rnd = new Random(); // we take it the instance for the assign the list object

            for (int i = 0; i < 10; i++) // we return the loop for the list object 
            {
                var number = rnd.Next(-15, 22); // we create the number for the list
                list.Add(number); // we asign add the number to list member

            }




            var doubleNumbers = list.Where(x => x % 2 == 0);// it is find the double number. if divide by 2 equals 0 this is the double number

            foreach (int x in doubleNumbers) //  loop the foreach all doublelist variable
            {
                Console.WriteLine($"Double Numbers {x}");// print the  double number
            }

            var singleNumbers = list.Where(y => y % 2 != 0);// it is find the single number. if divide by 2 not equals 0 this is the single number

            foreach (var y in singleNumbers) //loop the foreach all singlelist varibale
            {
                Console.WriteLine($"Single Numbers {y}");// print the  single number 
            }

            var negativeNumbers = list.Where(z => z < 0);// it is find the negative number. if less than by  0 this is the negative number


            foreach (var z in negativeNumbers)//loop the foreach all negative list varibale
            {
                Console.WriteLine($"Negative Numbers {z}"); // print the  negative number 
            }



            var positiveNumbers = list.Where(q => q > 0);// it is find the negative number. if greater than by  0 this is the positve number

            foreach (var q in positiveNumbers)//loop the foreach all positive list varibale

            {
                Console.WriteLine($"Positive Numbers {q}");// print the  positve number
            }

            var fifittenToTwentyTwo = list.Where(d => d > 15 && d < 22);// it is find the between 15 to 22 number. 
            foreach (var d in fifittenToTwentyTwo)//loop the foreach all 15 to 22 list varibale
            {
                Console.WriteLine($"15-22 Between {d}");// print the  between 15 to 22 number
            }
            var square = list.Select(sq => sq * sq);// it is callculated the all list members square

            foreach (var sq in square)//loop the foreach membersquare list varibale
            {
                {
                    Console.WriteLine($"List Square {sq}");// print the all list square
                }
            }
        }
    }
}