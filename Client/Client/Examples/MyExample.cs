using PMC_DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class MyExample
    {
        Random rnd1 = new Random();
        public Containers<int> BuildContainersMyExampl()
        {
            Containers<int> myContainer = new Containers<int>();
            myContainer.AddContainers(2);
            myContainer.AddMatrixInEachContainer(TypeMatrix.MatrixXYZ, 3);
            myContainer.AddMatrixInEachContainer(TypeMatrix.MatrixX, 2);
            myContainer.AddPositionsInEachMatrix(6);
            myContainer.AllocateMemoryForPoints3D(8);
            myContainer.AddContainers(1);//кількість контейнерів стало 3 і в доданому контейнері
                                         //така сама кількість матриць, позицій і точок 3д
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 6; k++)
                {
                    for (int j1 = 0; j1 < 3; j1++)
                        myContainer.SetRaingPoint3DInAllocatedMemory(i, j1, k, GenereteColectionPoint3D(8));
                    for (int j2 = 0; j2 < 2; j2++)
                        myContainer.AddRangePoint1D(i, j2+3, k, GenereteColectionPoint1D(rnd1.Next(10)));
                }
            }
            return myContainer;
        }
        public List<Point3D<int>> GenereteColectionPoint3D(int countPoint)
        {

            List<Point3D<int>> a = new List<Point3D<int>>();
            for (int i = 0; i < countPoint; i++)
                a.Add(new Point3D<int>(rnd1.Next(100), rnd1.Next(100), rnd1.Next(100)));
            return a;
        }
        public List<Point1D<int>> GenereteColectionPoint1D(int countPoint)
        {
            List<Point1D<int>> a = new List<Point1D<int>>();
            for (int i = 0; i < countPoint; i++)
                a.Add(new Point1D<int>(rnd1.Next(100)));
            return a;
        }

    }
}
