using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercise {
    class Exercise4 {
        public void PrimeNumbers() {
            Console.WriteLine("Question4:");
            Console.WriteLine("Please input an integer number");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= inputNumber; i++) {
                IsPrime(i);
            }
        }

        private static void IsPrime(int n) {

            bool flag = true;
            for (int i = 2; i < n - 1; i++) {
                if (n % i == 0) {
                    //Console.WriteLine($"{n} is Not prime");
                    flag = false;
                    break;
                }
            }
            if (flag) {
                Console.WriteLine($"{n} is Prime");
            }
        }

        
    }
}





