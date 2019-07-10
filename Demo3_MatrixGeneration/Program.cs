using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_MatrixGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the matrix");

            var result=  Process(3,1, new int[] { 2,0,1, 1 });
            result.ForEach(Console.WriteLine);
            Console.ReadKey();


        }

        private static List<string> Process(int upperRowSum, int lowerRowSum, int[] bothRowSumArray)
        {
            var result = new List<string>();
            var matrixLen = bothRowSumArray.Length   ;
            var outPutUpperMat = new int[matrixLen];
            var outPutLowerMat = new int[matrixLen];

            for (var i = 0; i < matrixLen; i++)
            {
                // If sum of T[i] + B[i] =2 , sure that both are 1

                if (bothRowSumArray[i] == 2)
                {
                    outPutUpperMat[i] = 1;
                    outPutLowerMat[i] = 1;
                    upperRowSum -= 1;
                    lowerRowSum -= 1;
                }
                // If sum of T[i] + B[i] =0 , sure that both are 0
                else if (bothRowSumArray[i] == 0)
                {
                    outPutUpperMat[i] = 0;
                    outPutLowerMat[i] = 0;

                }
                // deal is here if sum is 1, then it can be either in T / B rows
                else if (bothRowSumArray[i] == 1)
                {
                    if (upperRowSum == 0)
                        outPutUpperMat[i] = 0;
                    else if (lowerRowSum == 0)
                        outPutLowerMat[i] = 0;
                    else
                    { 
                    }
                }
            }
            var res = string.Join(",", outPutLowerMat);
            result.Add(res);
            var res2 = string.Join(",", outPutUpperMat);
            result.Add(res2);
            return result;
        }
    }
}
