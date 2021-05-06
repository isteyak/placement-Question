using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementQuestion.placement_que
{
   public class Find_middle_of_linkedlest
    {
        public Node FinsMiddle(Node head)
        {
            Node slow = head;
            Node fast = head.Next;
            while(fast!=null && fast.Next!=null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            return slow;
        }
    }
}
