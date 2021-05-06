using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementQuestion.placement_que
{
   public class Merge_2_sorted_linkedlist
    {

        public Node Merge_2_sorted_list(Node head1, Node head2)
        {
            Node L1 = null; Node L2 = null; Node temp = null;
            if (head1.val < head2.val)
            {
                L1 = head1;
                L2 = head2;
            }
            else { L2 = head1; L1 = head2; }
            while(L1!=null && L2!=null)
            {
                if(L1.val < L2.val)
                {
                    temp = L1;
                    L1 = L1.Next;
                }
                else
                {
                    temp.Next = L2;
                    Node t = L1;
                    L1 = L2;
                    L2 = t;
                }
            }
            if (L1 != null)
            {
                temp.Next = L1;
            }
            else temp.Next = L2;
            return head2;
        }
    }
}
