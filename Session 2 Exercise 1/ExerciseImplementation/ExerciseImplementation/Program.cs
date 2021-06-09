using System;

namespace Session1Exercise1 {
    class Program {
        private static object sumOfMultiply;

        static void Main(string[] args) {
            //Answer 1
            Console.WriteLine("Answer1: Hello,my name is Petsinas Thanasis");

            //Answer 2
            int number1 = 20, number2 = 10;

            Console.WriteLine($"Answer2:The sum of {number1} and {number2} is : {number1 + number2}");
            Console.WriteLine($"Answer2:The diving of {number1} and {number2} is : {number1 / number2}");


            //Answer 3
            int sumQuestion3_1 = -1 + 5 * 6;
            Console.WriteLine($"Answer 3.1:The result of -1+5*6 is={sumQuestion3_1}");
            //3.2
            decimal sumQuestion3_2 = 38 + 5 % 7;
            Console.WriteLine($"Answer 3.2:The result of 38+5mod7 is={sumQuestion3_2}");
            //3.3
            double sumQuestion3_3 = 14 + (-3 * 6.0) / 7;
            Console.WriteLine($"Answer 3.3:The result of 14 + ((-3 * 6) / 7 ) is={sumQuestion3_3} ");
            //3.4
            double sumQuestion3_4 = 2 + (13 / 6 * 6) + Math.Sqrt(7);
            Console.WriteLine($"Answer 3.4:The result of 2+(13 / 6) * 6 +  √7 is {sumQuestion3_4}");
            //3.5
            double sumQuestion3_5 = ((Math.Pow(6, 4)) + (Math.Pow(5, 7)) / 9 % 4);
            Console.WriteLine($"Answer 3.4:The result of (6^4 + 5^ 7)/(9mod4) is {sumQuestion3_5}");

            //Answer 4




            Console.WriteLine("Question 4,please input 3 numbers.");
            Console.WriteLine("Please input 1st number:");
            string multFirstNumber = Console.ReadLine();
            Console.WriteLine("Please input 2nd number:");
            string multSecondNumber = Console.ReadLine();
            Console.WriteLine("Please input 3rd number:");
            string multThirdNumber = Console.ReadLine();

            //int multThirdNumber = Convert.ToInt32(Console.ReadLine());

            int sumOfMultiply = MultiplyThreeNumbers(int.Parse(multFirstNumber), int.Parse(multSecondNumber), int.Parse(multThirdNumber));

            Console.WriteLine($"Answer 4:The multiplication of the numbers you have given is: {sumOfMultiply}");

            //stringFirstNumber,stringSecondNumber,stringThirdNumber



            static int MultiplyThreeNumbers(int number1, int number2, int number3) {

                return number1 * number2 * number3;
            }


            //Answer 5
            Console.WriteLine("Question 5,input 5 numbers.");
            Console.WriteLine("Please input 1st number:");
            string calcFirstNumber = Console.ReadLine();
            Console.WriteLine("Please input 2nd number:");
            string calcSecondNumber = Console.ReadLine();
            Console.WriteLine("Please input 3rd number:");
            string calcThirdNumber = Console.ReadLine();
            Console.WriteLine("Please input 4th number:");
            string calcFourthNumber = Console.ReadLine();
            Console.WriteLine("Please input 5th number:");
            string calcFifthNumber = Console.ReadLine();

            int averageOfNumbers = CalculateAverage(int.Parse(calcFirstNumber), int.Parse(calcSecondNumber), int.Parse(calcThirdNumber), int.Parse(calcFourthNumber), int.Parse(calcFifthNumber));
            Console.WriteLine($"Answer 5:The average of the five numbers you have given is :{averageOfNumbers}");



            static int CalculateAverage(int number1, int number2, int number3, int number4, int number5) {
                return (number1 + number2 + number3 + number4 + number5) / 5;
            }


            //Answer 6

            Console.WriteLine("Question 6,input an age and a gender,male or female.");

            Console.WriteLine("Please input your age:");
            string age = Console.ReadLine();
            int intAge = int.Parse(age);

            Console.WriteLine("Please input your gender:");
            string gender = Console.ReadLine();

            DisplayFinalOutput(intAge, gender);
            static void DisplayFinalOutput(int age, string gender) {
                Console.WriteLine($"You are {gender} and look younger than {age}");
            }


            //Answer 7

            Console.WriteLine("Question 7:");

            Console.WriteLine("Please input an integer:");
            string seconds = Console.ReadLine();
            int intSeconds = int.Parse(seconds);

            int toMinutes = ConvertToMinutes(intSeconds);
            int toHours = ConvertToHours(intSeconds);
            int toDays = ConvertToDays(intSeconds);
            int toYears = ConvertToYears(intSeconds);

            Console.WriteLine($"To minutes:{toMinutes}");
            Console.WriteLine($"To hours:{toHours}");
            Console.WriteLine($"To days:{toDays}");
            Console.WriteLine($"To years:{toYears}");

            static int ConvertToMinutes(int seconds) {
                return seconds / 60;
            }
            static int ConvertToHours(int seconds) {
                return seconds / 60 / 60;
            }
            static int ConvertToDays(int seconds) {
                return seconds / 60 / 60 / 24;
            }
            static int ConvertToYears(int seconds) {
                return seconds / 60 / 60 / 24 / 365;

            }

            //Answer 8
            Console.WriteLine("Question 8");
            Console.WriteLine("Please input an integer:");
            string example8seconds = Console.ReadLine();
            double doubleSeconds = double.Parse(example8seconds);

            TimeSpan time = TimeSpan.FromSeconds(doubleSeconds);
            Console.WriteLine($"seconds in minutes:{time.TotalDays}");
            Console.WriteLine($"seconds in hours:{time.TotalHours}");
            Console.WriteLine($"seconds in days:{time.TotalDays}");
            Console.WriteLine($"seconds in years:{time.TotalDays / 365}"); //Couldnt find -->TotalYears





            //Answer 9 
            Console.WriteLine("Question 9:");
            Console.WriteLine("Please input celsius degrees:");
            string degrees = Console.ReadLine();
            double floatDegrees = double.Parse(degrees);

            double kelvinDegrees = CelsiusToKelvin(floatDegrees);
            double fahrenheitDegrees = CelsiusToFahrenheit(floatDegrees);

            Console.WriteLine($"Celsius to Kelvin={kelvinDegrees}");
            Console.WriteLine($"Celsius to fahrenheit={fahrenheitDegrees}");



            static double CelsiusToKelvin(double degrees) {
                return degrees + 273.15;
            }

            static double CelsiusToFahrenheit(double degrees) {
                return degrees + 32;
            }

            //Answer 10
            Console.WriteLine("Question 10:");
            Console.WriteLine("Please input a string:");
            string input = Console.ReadLine();
            Console.WriteLine(input.Replace("a", ""));

        }
    }
}
