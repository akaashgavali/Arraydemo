//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arraydemo
//{
//    internal class Minimum2dArray
//    {
//        static void Main(string[] args)
//        {
//            int[,] arr = new int[3, 4]
//                {
//                    {1,2,3,4 },
//                    {5,6,7,8 },
//                    {9,10,11,12 }
//               };
//            int row = arr.GetLength(0);
//            int col = arr.GetLength(1);
//            int lowest = arr[0, 0];
//            for(int i=0;i<row;i++)
//            {
//                for(int j=0; j < col; j++)
//                {
//                    int num = arr[i, j];
//                    if (num < lowest)
//                        lowest = num;
//                }
//            }
//            Console.WriteLine(lowest);
//        }
//    }
//}
