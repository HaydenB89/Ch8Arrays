using System;

namespace Ch8ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] ages = {1,4,6,27,31,32,63,65};

            int sum = 0;
            for(int idx = 0; idx < ages.Length; idx++)
            {
                sum += ages[idx];
            }
            Console.WriteLine($"sum is {sum}");
            */

            //foreach loop *easier than the above statement
            int[] ages = { 1, 4, 6, 27, 31, 32, 63, 65 };

            int sum = 0;
            foreach(int age in ages)
            {
                sum += age;
            }
            Console.WriteLine($"sum is {sum}");
        }
    }
}
