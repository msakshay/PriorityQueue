using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueues
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            PriorityQueue<int> pq = new PriorityQueue<int>();   
            pq.Add(1);
            pq.Add(4);
            pq.Add(2);
            pq.Add(3);

            while (pq.Size > 0)
            {
                var val = pq.Poll();
                Console.WriteLine(val);
                
            }

            Console.ReadLine();
        }
    }
}
