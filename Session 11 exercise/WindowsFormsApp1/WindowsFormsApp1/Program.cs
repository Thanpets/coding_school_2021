using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Base;
using WindowsFormsApp1.WUI;
using WindowsFormsApp1.Zoo;

namespace WindowsFormsApp1 {


    static class Program {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {


            //University epsilonUni = new University();
            //epsilonUni.Init();

            // 1.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // inversion of control ...
            AnimalHandler animalHandler = new AnimalHandler();

            Console.WriteLine(animalHandler.Move(new Cat()));


            Cat cat = new Cat();
            cat.DoMove();

            Console.WriteLine(animalHandler.Move(new Dog()));

            Console.ReadLine();

            Application.Run(new MdiMainForm());

        }
    }
}
