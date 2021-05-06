using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementQuestion.placement_que
{
    public class ReverseList
    {
        public ReverseList()
        {
        }

        public Node Reverse_list(Node head)
        {
            Node current = null;
            Node next = null;

            while(head != null)
            {
                next = head.Next;
                head.Next = current;
                current = head;
                head = next;
            }
            return current;
        }
    }
}
