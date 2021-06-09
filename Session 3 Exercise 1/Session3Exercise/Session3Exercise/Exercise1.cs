using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercise {
    class Exercise1 {

        public string longestString = "";
        public string output { get; set; }
        public void StringCheck(string myString) //Question 1
        {
            string[] words = myString.Split(new[] { " " }, StringSplitOptions.None);


            foreach (String word in words) {
                if (word.Length > longestString.Length) {
                    longestString = word;
                }
            }

            foreach (String word in words) {
                if (word == longestString) {
                    output += word.ToUpper();
                    output += " ";
                }
                else {
                    output += word;
                    output += " ";
                }
            }

            Console.WriteLine(output.Trim());
            //Console.ReadLine();

        }


    }
}
