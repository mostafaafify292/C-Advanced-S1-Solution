using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_S1
{
    internal static class Helper<T>where T:IComparable
    {

        public static void SWAP(ref T X ,ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }
        public static void BubbleSort(T[] arr1)
        {
            if (arr1 is not null)
            {
                for (int i = 0; i < arr1.Length; i++)
                { 
                    //we optimize BubbleSort when we make [arr1.lenth-i-1]
                    for (int j = 0; j < arr1.Length-i-1; j++)
                    {
                        if (arr1[j].CompareTo(arr1[j+1]) == 1)
                        {
                            Helper<T>.SWAP(ref arr1[j],ref arr1[j + 1]);
                        }
                    }
                }
            }

        }


    }
}
