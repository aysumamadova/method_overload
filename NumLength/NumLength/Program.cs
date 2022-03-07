using System;

namespace NumLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NumLength metodu ucun 1");
            Console.WriteLine("Min metodu ucun 2");
            Console.WriteLine("VowelLetter  metodu ucun 3");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num==1)
            {
                NumLength();
            }
            else if (num==2)
            {
                Min();
            }
            else if (num==3)
            {
                VowelLetter();
            }
        }

        static void Min()
        {
            int[] arr = {-9,7,12,22,30,67};
            int small = 0;
            small = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (small > arr[i])
                {
                    small = arr[i];
                }
            }
            Console.WriteLine("En kiçik element: " + small);
        }

        static void NumLength()
        {
            Console.WriteLine("eded daxil edin");
            decimal num = Convert.ToInt64(Console.ReadLine());
            int count = 0;
            while (num>1)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine(count);
        }

        static void VowelLetter()
        {
            Console.Write("Soz daxil edin : ");
            string word = Convert.ToString(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a'||word[i] == 'A'|| word[i] == 'o'|| word[i] == 'u' || word[i] == 'e' || word[i] == 'E' || word[i] == 'i' || word[i] == 'O' || word[i] == 'U' || word[i]=='I')
                {
                    sum++;
                }

            }
            if (sum > 0)
            {
                Console.WriteLine(sum + "sait var");
            }
            else
            {
                Console.WriteLine("sait yoxdu");
            }
        }
    }
}
