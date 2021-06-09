using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercise {
    class Program {
        static void Main(string[] args) {

            //Answer to question 1
            Exercise1 answer1 = new Exercise1();
            Console.WriteLine("Question 1:");
            answer1.StringCheck("lorem ipsum dolor sit amet consectetur adipiscing elit");

            //Answer to question 2
            Console.WriteLine("Question 2:");
            Exercise2 answer2 = new Exercise2();
            Console.WriteLine("Please input a string to reverse");
            string strAnswer2 = Console.ReadLine();
            answer2.ReverseString(strAnswer2);

            //Console.ReadLine();

            //Answer to Question 3
            Exercise3 answer3 = new Exercise3();
            answer3.CalculatingSumOrProduct();
            //Console.ReadLine();

            //Answer to question 4
            Exercise4 answer4 = new Exercise4();
            answer4.PrimeNumbers();
            //Console.ReadLine();

            //Answer to question 5
            Exercise5 answer5 = new Exercise5();
            answer5.ArraysMultiply();
            Console.ReadLine();

            //Answer 6 not enough time...im already late.

        }
    }
}
