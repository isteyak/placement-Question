using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementQuestion.placement_que
{
    public class Remove_nth_Node_from_last
    {

        public Node Remove_nth_node_in_list(Node head, int n)
        {
            Node start = new Node();
            start.Next = head;
            Node slow = start;
            Node fast = start;
            for(int i = 0; i<= n; i++)
            {
                fast = fast.Next;
            }
            while(fast!=null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }
            slow.Next = slow.Next.Next;
            return head;
        }
    }
}
