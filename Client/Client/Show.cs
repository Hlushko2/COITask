using PMC_DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Show<T>
    {
        public void ShowConsole(Containers<T> cont)
        {
            int i = 0, j = 0;
            foreach (var container in cont)
            {
                i++;
                Console.WriteLine("container " + i.ToString() + "\n");
                System.Threading.Thread.Sleep(300);
                foreach (var matrix in container)
                {
                    j = 0;
                    if (matrix is MatrixX<T>)
                    {
                        Console.WriteLine("\tMatrixX");
                        System.Threading.Thread.Sleep(300);
                        foreach (var positionX in (MatrixX<T>)matrix)
                        {
                            j++;
                            Console.WriteLine("\t\tpositionX " + j);
                            foreach (var point1D in positionX)
                            {
                                Console.Write(point1D.ValueX + " ");
                            }
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                    if (matrix is MatrixXY<T>)
                    {
                        Console.WriteLine("\tMatrixXY");
                        foreach (var positionXY in (MatrixXY<T>)matrix)
                        {
                            j++;
                            Console.WriteLine("\t\tpositionXY " + j);
                            foreach (var point2D in positionXY)
                            {
                                Console.Write("(" + point2D.ValueX + ", " + point2D.ValueY + ") ");
                            }
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                    if (matrix is MatrixXYZ<T>)
                    {
                        Console.WriteLine("\tMatrixXYZ");
                        foreach (var positionXYZ in (MatrixXYZ<T>)matrix)
                        {
                            j++;
                            Console.WriteLine("\t\tpositionXYZ " + j);
                            foreach (var point3D in positionXYZ)
                            {
                                Console.Write("(" + point3D.ValueX + ", " + point3D.ValueY + ", " + point3D.ValueZ + ") ");
                            }
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                }
            }
        }
        }
}
