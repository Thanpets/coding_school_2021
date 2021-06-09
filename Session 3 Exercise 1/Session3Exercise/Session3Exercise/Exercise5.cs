using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercise {
    class Exercise5 {

        public void ArraysMultiply() {
            Console.WriteLine("Multiply of arrays [2, 4, 9, 12] and [1, 3, 7, 10]");
            int[] array1 = { 2, 4, 9, 12 };
            int[] array2 = { 1, 3, 7, 10 };
            
            for (int i = 0; i < array1.Length; i++) {
                int sum = 0;
                for (int j = 0; j < array2.Length; j++) {
                    sum = array1[i] * array2[j];
                    Console.WriteLine($"{sum}");

                }

            }
            
        }
    }
}
