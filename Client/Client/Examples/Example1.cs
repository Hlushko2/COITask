using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMC_DataModel;
namespace Client
{
    //Example 1:  A container collection contains 3 containers.
    //    All data points are decimal.  Each matrix contains 100 positions.
    //    Each container contains 2 matrices with the first matrix in each
    //    container being XY data and the second matrix in each container being X data.
    //    Position 1 of the XY data contains 50 points.Position 2 of the XY data contains 200 points.
    //    The other XY positions are empty.Position 1 and 2 of the X data matrix
    //        contain a numerical value, the others do not
    class Example1
    {
        Random rnd1 = new Random();
        public Containers<decimal> BuildContainersExampl1()
        {
            Containers<decimal> a = new Containers<decimal>(3, 1, 1, 0, 100);
            a.AllocateMemoryForPoints2DInEachContainer(1, 0, 50);
            a.AllocateMemoryForPoints2DInEachContainer(1, 1, 200);
            for (int i = 0; i < 3; i++)
            {
                a.SetRaingPoint2DInAllocatedMemory(i, 1, 0, GenereteColectionPoint2D(50));
                a.SetRaingPoint2DInAllocatedMemory(i, 1, 1, GenereteColectionPoint2D(200));
                a.AddRangePoint1D(i, 0, 0, GenereteColectionPoint1D(rnd1.Next(15, 250)));
                a.AddRangePoint1D(i, 0, 1, GenereteColectionPoint1D(rnd1.Next(60, 250)));
            }
            return a;
        }
       public List<Point2D<decimal>> GenereteColectionPoint2D(int countPoint)
        {
            
            List<Point2D<decimal>> a = new List<Point2D<decimal>>();
            for (int i = 0; i < countPoint; i++)
                a.Add(new Point2D<decimal>((decimal)(rnd1.NextDouble()*1000), (decimal)(rnd1.NextDouble() * 1000)));
            return a;
        }

        public List<Point1D<decimal>> GenereteColectionPoint1D(int countPoint)
        {
            List<Point1D<decimal>> a = new List<Point1D<decimal>>();
            for (int i = 0; i < countPoint; i++)
                a.Add(new Point1D<decimal>((decimal)(rnd1.NextDouble() * 1000)));
            return a;
        }


    }
}
