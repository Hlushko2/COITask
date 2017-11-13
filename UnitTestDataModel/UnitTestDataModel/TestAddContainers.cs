using NUnit.Framework;
using PMC_DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDataModel
{
    [TestFixture]
    public class UnitTest2
    {
        [Test]
        public void TestAddContainers()
        {
            int countAddedContainers = 2;
            Containers<int> TestContainer = new Containers<int>(6, 10, 20, 30, 50);
            TestContainer.AllocateMemoryForPoints2DInEachContainer(10, 48, 200);
            TestContainer.SetRaingPoint2DInAllocatedMemory(2, 10, 48, new List<Point2D<int>>() { new Point2D<int>(1,1),
            new Point2D<int>(1,2), new Point2D<int>(1,3), new Point2D<int>(1,4), new Point2D<int>(1,5)});
            TestContainer.AllocateMemoryForPoints3D(120);
            TestContainer.SetRaingPoint3DInAllocatedMemory(1, 49, 0, new List<Point3D<int>>() { new Point3D<int>(1,2,3),
            new Point3D<int>(1,2,3),new Point3D<int>(1,2,3)});
            Assert.AreEqual(1, (TestContainer[1][49] as MatrixXYZ<int>)[0][0].ValueX);
            Assert.AreEqual(2, (TestContainer[1][49] as MatrixXYZ<int>)[0][0].ValueY);
            Assert.AreEqual(3, (TestContainer[1][49] as MatrixXYZ<int>)[0][0].ValueZ);
            Assert.AreEqual(0, (TestContainer[1][49] as MatrixXYZ<int>)[0][3].ValueX);

            TestContainer.AddContainers(countAddedContainers);

            int NumbMatrixX = 0;
            int NumbMatrixXY = 0;
            int NumbMatrixXYZ = 0;
            int NumbPositions = 0;
            foreach (var matrix in TestContainer[7])
            {
                if (matrix is MatrixX<int>)
                {
                    NumbMatrixX++;
                    NumbPositions = 0;
                    foreach (var positionX in (MatrixX<int>)matrix)
                    {
                        NumbPositions++;
                    }
                    Assert.AreEqual(50, NumbPositions); //перевіряє чи в кожній матриці кількість позицій =50
                }
                if (matrix is MatrixXY<int>)
                {
                    NumbMatrixXY++;
                    NumbPositions = 0;
                    foreach (var positionXY in (MatrixXY<int>)matrix)
                    {
                        NumbPositions++;
                    }
                    Assert.AreEqual(50, NumbPositions);
                }
                if (matrix is MatrixXYZ<int>)
                {
                    NumbMatrixXYZ++;
                    NumbPositions = 0;
                    foreach (var positionXYZ in (MatrixXYZ<int>)matrix)
                    {
                        NumbPositions++;
                    }
                    Assert.AreEqual(50, NumbPositions);
                }
            }
            Assert.AreEqual(10, NumbMatrixX);
            Assert.AreEqual(20, NumbMatrixXY);
            Assert.AreEqual(30, NumbMatrixXYZ);
        }
    }
}
