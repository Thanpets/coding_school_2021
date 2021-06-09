using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise {
    class RecursionClass {

        public int DeciToBinary(int num) {

            int bin;
            if (num != 0) {
                bin = (num % 2) + 10 * DeciToBinary(num / 2);
                Console.Write(bin);
                return 0;
            }
            else {
                return 0;
            }
        }
    }
}
