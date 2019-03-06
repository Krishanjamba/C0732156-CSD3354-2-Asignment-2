using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732156_CSD3354_2_Asignment_2
{


    public delegate void MyDelegate();

    public class DelegateExercises
    {
        void Method3()
        {
            System.Console.WriteLine(MyDelegate.ToString());
        }
    }
}