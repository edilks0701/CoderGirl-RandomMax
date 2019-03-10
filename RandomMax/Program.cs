using System;

namespace RandomMax
{
    public static class Program
    {
        public static void Main()
        {

            int[] num = new int[101];
            Random r = new Random();
            int largestNumber;


            for (int i = 0; i < 101; i++)
            {
                num[i] = r.Next(0, 1001);
               
            }

            largestNumber = num[0];


            for (int i = 0; i < 101; i++)
            {
                if (largestNumber < num[i]) largestNumber = num[i];

               

            }
            Console.WriteLine(largestNumber);

            


            Console.ReadLine();




        }
    }
}
