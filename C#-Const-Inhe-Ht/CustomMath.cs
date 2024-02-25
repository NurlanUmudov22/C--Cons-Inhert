using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Constr_Inheri_Hometask
{
    internal class CustomMath
    {
        //2.1/ Method array qebul edir, arrayin icerisindeki tek ededlerin cemini tapin.


        public int SumOfOddInArray( int[] nums)
        {
            int sum = 0;

            foreach ( int num in nums ) 
            {
                if (num % 2 == 1)
                {
                    sum += num;
                }
            }
            return sum;
        }



          //2.2)Methoda gelen ededin tek ve ya cut olub olmamasini gosterin.

        public string OddOrEvenNum(int m)
        {
            if (m % 2 == 1)
            {
                return "Eded tekdir";
            }
            else
            {
                return "Eded cutdur";
            }

        }


             // 2.3) Methoda gelen arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.

        public int SumOfEvenNums(int[] arr)
        {
            int sum = 0;

            foreach ( var num in arr )
            {
                if ( num % 2 == 0 )
                {
                    sum += num;
                }
            }

            int power = sum * sum;

            return power;
        }


        // 2.4) Methoda n ededi gelir, 1-den n ededine qeder olan ededlerin hasilini tapin.


        public int MultiOfNums(int n)
        {
            int multi = 1;

            for (int i = 1; i < n; i++)
            {
                if (n > 1)
                {
                    multi *= i;
                }
            }
            return multi;

        }























        //public void MultiOfNums(int n)
        //{
        //    int multi = 1;

        //    for (int i = 1; i < n; i++)
        //    {
        //        if (n > 1)
        //        {
        //            multi *= i;
        //        }
        //    }
        //    Console.WriteLine(multi); 

        //}









    }
}
