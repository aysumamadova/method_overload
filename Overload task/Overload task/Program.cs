using System;

namespace Overload_task
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine(Area(4, -6, 6, 4));
        }

        static int Area(int radius)
        //Çevrənin sahəsi
        {
            if (radius>0)
            {
                return radius * radius * 3;
            }
            else
            {
                return -1;
            }
        }

        static int Area(int a, int b)
           // Düzbucaqlının sahəsi
        {
            if (a>0 & b>0)
            {
                return a * b;
            }
            else
            {
                return -1;
            }
        }

        static int Area(int a, int b, int c)
        // Düzbucaqlı paralelpipedin tam səthinin sahəsi 
        {
            if (a>0 & b>0 & c>0)
            {
                return (a * b + a * c + b * c) / 2;
            }
            else
            {
                return -1;
            }
            
        }

        static int Area(int a, int b, int c, int r)
        //Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi
        {
            if (a>0 & b>0 & c>0 & r>0)
            {
                int p = (a + b + c);
                return p * r;
            }
            else
            {
                return -1;
            }

        }
             
    }
}
         