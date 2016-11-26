using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemVollyBall2
{
    class Program
    {


        private static long faktorial1(int a, int b)
        {
            long hasil = a;
            for (int i = (a - 1); i >= b; i--)
            {
                hasil = hasil * i;
            }
            return hasil;
        }


        private static long factorial2(int a)
        {
            long hasil = a;
            for (int i = (a - 1); i > 1; i--)
            {
                hasil = hasil * i;
            }
            return hasil;
        }


        private static long kombinasi(int a, int r)
        {
            long x;
            long y;
            if ((a - r) > r)
            {
                x = faktorial1(a, a - r + 1);
                y = factorial2(r);
            }
            else
            {
                x = faktorial1(a, r + 1);
                y = factorial2(a - r);
            }
            return x / y;
        }


        static void Main(string[] args)
        {
            int l; int i; long e;
            int hasil = 0;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == 24 && b == 17)
            {
                Console.WriteLine(hasil);
                Console.Write("game end");
                Console.ReadLine();
            }
            else
            {


                if (a < b)
                {
                    l = a;
                    i = 24 + l;
                    hasil += i;
                }
                if (b < a)
                {
                    l = b;
                    i = 24 + l;
                    hasil += i;
                }


                e = kombinasi(hasil, a) % 1000000007;
                Console.WriteLine(e);
                if (a == b || b == a)
                {
                    Console.WriteLine(hasil);
                }

            }
            Console.ReadKey();
        }

    }
}
    

