using NUnit.Framework;
using PMC_DataModel;
using System;
using System.Collections.Generic;

namespace UnitTestDataModel
{
    [TestFixture]
    public class UnitTest1
    {
        Containers<int> ConstructorWithoutParam;
        Containers<int> ConstructorWith1Param;
        Containers<int> ConstructorWith4Param;
        int countContainer=3;
        int countMatrixX = 2;
        int countMatrixXY = 4;
        int countMatrixXYZ = 5;
        [SetUp]
        public void Constructors()
        {
            ConstructorWithoutParam = new Containers<int>();
            ConstructorWith1Param = new Containers<int>(countContainer);
            ConstructorWith4Param = new Containers<int>(countContainer, countMatrixX, countMatrixXY, countMatrixXYZ);
        }

        [Test]
        public void TestConstructorWithoutParam()
        {
            int i = 0;
            foreach(var a in ConstructorWithoutParam)
            {
                i++;
            }
            Assert.AreEqual(0, i);
        }

        [Test]
        public void TestConstructorWith1Param()
        {
            int i = 0;
            foreach (var a in ConstructorWith1Param)
            {
                i++;
            }
            Assert.AreEqual(countContainer, i);
            Assert.AreEqual(countContainer, ConstructorWith1Param.CountContainers);
        }
        [Test]
        public void TestConstructorWith4Param()
        {
            int NumbContainres = 0;
            int NumbMatrixX = 0;
            int NumbMatrixXY = 0;
            int NumbMatrixXYZ = 0;

            foreach (var a in ConstructorWith4Param)
            {
                NumbContainres++;
            }
            
                foreach(var matrix in ConstructorWith4Param[0])
                {
                    if (matrix is MatrixX<int>)
                        NumbMatrixX++;
                    if (matrix is MatrixXY<int>)
                        NumbMatrixXY++;
                    if (matrix is MatrixXYZ<int>)
                        NumbMatrixXYZ++;
                }            
            Assert.AreEqual(countContainer, NumbContainres);
            Assert.AreEqual(countContainer, ConstructorWith4Param.CountContainers);
            Assert.AreEqual(countMatrixX, NumbMatrixX);
            Assert.AreEqual(countMatrixX, ConstructorWith4Param.CountInEachConainerMatrixX);
            Assert.AreEqual(countMatrixXY, NumbMatrixXY);
            Assert.AreEqual(countMatrixXY, ConstructorWith4Param.CountInEachConainerMatrixXY);
            Assert.AreEqual(countMatrixXYZ, NumbMatrixXYZ);
            Assert.AreEqual(countMatrixXYZ, ConstructorWith4Param.CountInEachConainerMatrixXYZ);
        }
    }
}
