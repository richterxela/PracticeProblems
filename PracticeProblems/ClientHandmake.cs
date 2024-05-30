using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestProblems
{
    public class ClientHandmake
    {
        public void Main()
        {
            Console.WriteLine(Handmake(new int[] { 3, 1, 2 }));
            Console.WriteLine(Handmake(new int[] { 1,2,3,4 }));
            Console.WriteLine(Handmake(new int[] { 7,7,7 }));
        }


        //Create a function that will calculate the total time that clients need to wait for all ordered items
        //There are N clients who have ordered N handmade items. The K-th client ordered exactly one item that takes T[K] hours to make. There is only one employee who makes items for clients, and he/she works in the following manner:
        //spend 1 hour making the first item
        //if the item is finished, deliver it
        //if the item is NOT finished, put it after ALL REMAINING ITEMS for futher work
        //employee then works on next item
        //What is the total time that clients need to wait for all ordered items?
        //
        //Example: T = [3, 1, 2]
        //
        //In this example, the 1st item takes 3 hours to make, the 2nd item takes 2 hours, and the 3rd item takes 2 hours. Here is how the employee goes about finishing all items: [1st, 2nd, 3rd, 1st, 3rd, 1st].
        //It ended up taking 6 passing hours to finish the first item, 2 passing hours the second item, and 5 passing hours for the third item. Summing all this up, we get the answer of 13.

        private static int Handmake(int[] T)
        {
            int currentime = 0;
            int totaltime = 0;
            Queue<int> q = new Queue<int>(T.Length);

            foreach (int i in T)
            {
                q.Enqueue(i);
            }

            while (q.Count != 0)
            {
                int item = q.Dequeue();
                currentime += 1;
                Console.WriteLine($"{item} {currentime}");

                if (item == 1)
                {
                    totaltime += currentime;
                }
                else
                {
                    q.Enqueue(item - 1);
                }
                
            }


            return totaltime;
        }
    }

}
