using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercise {
    class Exercise3 {
        public void CalculatingSumOrProduct() {
            Console.WriteLine("Question3:");
            Console.WriteLine("Please input an integer number");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Please input  sum to calculate the sum or product to calculate the factorial of {inputNumber}");
            string inputString = Console.ReadLine();






            if (inputString == "sum") {
                int result = 0;
                for (int i = 1; i < inputNumber + 1; i++) {
                    result += i;
                }
                Console.WriteLine($"The sum of 1+....+{inputNumber} is :{result}");

            }
            else if (inputString == "product") {
                int result = 1;
                for (int i = 1; i <= inputNumber; i++) {
                    result *= i;
                }
                Console.WriteLine($"The factorial of {inputNumber} is:{result}");
            }







        }
    }
}
