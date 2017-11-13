using PMC_DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    //Example 2:  A container collection contains 10 containers.All data points are double.
    //Each container contains 10 matrices with the first 5 matrices being XY data and the remaining
    //5 being X data.All positions in all matrices contain values.

    class Example2
    {
        Random rnd1 = new Random();
        public Containers<double> BuildContainersExampl2()
        {
            Containers<double> a = new Containers<double>(10, 5, 5, 0, 10);
            for (int i = 0; i < 5; i++)
            {
                for(int j=0;j<10;j++)
                a.AllocateMemoryForPoints2DInEachContainer(5 + i, j, rnd1.Next(5, 15));
            }          
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        a.SetRaingPoint2DInAllocatedMemory(i, j + 5, k, GenereteColectionPoint2D(rnd1.Next(5, 15)));
                        a.AddRangePoint1D(i, j, k, GenereteColectionPoint1D(rnd1.Next(1, 20)));
                    }                  
                }
            }
            return a;
        }
        public List<Point2D<double>> GenereteColectionPoint2D(int countPoint)
        {

            List<Point2D<double>> a = new List<Point2D<double>>();
            for (int i = 0; i < countPoint; i++)
                a.Add(new Point2D<double>((rnd1.NextDouble() * 100), (rnd1.NextDouble() * 100)));
            return a;
        }
        public List<Point1D<double>> GenereteColectionPoint1D(int countPoint)
        {
            List<Point1D<double>> a = new List<Point1D<double>>();
            for (int i = 0; i < countPoint; i++)
                a.Add(new Point1D<double>((rnd1.NextDouble() * 100)));
            return a;
        }


   }
}
