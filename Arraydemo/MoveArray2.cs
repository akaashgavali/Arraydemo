//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arraydemo
//{
//    internal class MoveArray2
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 2, 10, 0, 5, 3, 0, 4, 1 };
//            int count = 0;
        
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] != 0)
//                {
//                    arr[count] = arr[i];
//                    count++;
//                }
//            }
//            while (count < arr.Length)
//            {
//                arr[count] = 0;
//                count++;
//            }
//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.WriteLine(arr[i] + " ");
//            }

//        }
//    }
//}