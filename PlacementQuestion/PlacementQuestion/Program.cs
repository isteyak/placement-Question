using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlacementQuestion.placement_que;


namespace PlacementQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Node h1 = new Node(2);
            h1.Next = new Node(4);
            h1.Next.Next = new Node(3);

            Node h2 = new Node(5);
            h2.Next = new Node(6);
            h2.Next.Next = new Node(7);
            h2.Next.Next.Next = new Node(9);

            add_two_list add_list = new add_two_list();

            var result = add_list.Add_Two_list(h1, h2);

            while(result!=null)
            {
                Console.WriteLine(result.val);
                result = result.Next;
            }
            
            Console.ReadLine();
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= boundary; i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
