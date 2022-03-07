using System;

namespace Overload_task
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine(Area(4,4,7));
        }

        static int Area(int radius)
       
        {
            if (radius>0)
            {
                Console.WriteLine("Çevrenin sahesi:");
                return radius * radius * 3;
                
            }
            else
            {
                return -1;
            }
        }

        static int Area(int a, int b)
           
        {
            if (a>0 & b>0)
            {
                Console.WriteLine("Düzbucaqlının sahesi:");
                return a * b;
            }
            else
            {
                return -1;
            }
        }

        static int Area(int a, int b, int c)
        
        {
            if (a>0 & b>0 & c>0)
            {
                Console.WriteLine("Düzbucaqlı paralelpipedin tam sehtinin sahesi:");
                return (a * b + a * c + b * c) / 2;
            }
            else
            {
                return -1;
            }
            
        }

        static int Area(int a, int b, int c, int r)
        
        {
            if (a>0 & b>0 & c>0 & r>0)
            {
                Console.WriteLine("Üçbucaqlının daxiline çekilmiş çevrenin sahesi:");
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
         