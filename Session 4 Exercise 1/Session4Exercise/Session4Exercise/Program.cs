using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise {
    class Program {
        static void Main(string[] args) {
            //Answer 1
            Console.WriteLine("Please input a decimal number");
            int num = int.Parse(Console.ReadLine());
            RecursionClass answer1 = new RecursionClass();
            answer1.DeciToBinary(num);
            Console.ReadLine();



        }
    }
}
