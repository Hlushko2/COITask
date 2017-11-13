using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMC_DataModel;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Show<decimal> show1 = new Show<decimal>();
            Example1 example1 = new Example1();
           // show1.ShowConsole(example1.BuildContainersExampl1());

            Show<double> show2 = new Show<double>();
            Example2 example2 = new Example2();
           // show2.ShowConsole(example2.BuildContainersExampl2());

            Show<int> show3 = new Show<int>();
            MyExample myExample = new MyExample();
            show3.ShowConsole(myExample.BuildContainersMyExampl());

        }
    }
}
