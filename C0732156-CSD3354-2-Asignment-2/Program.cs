using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732156_CSD3354_2_Asignment_2
{
    namespace DelegatesAndEvents
    {
        public class Program
        {
            public static void Main()
            {
                DelegateExercises delegateExercises = new DelegateExercises();
                delegateExercises.Method3();
                Console.ReadLine();
            }

        }
        public delegate void MyDelegate();

        public class DelegateExercises
        {
            void Method1()
            {
                System.Console.WriteLine("Method1");
            }
            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }
        }

    }
}

    