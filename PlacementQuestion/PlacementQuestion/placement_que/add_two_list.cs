using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementQuestion.placement_que
{
    class add_two_list
    {

        public Node Add_Two_list(Node H1, Node H2)
        {
            Node dumy = new Node(0);
            Node temp = dumy;
            Node l1 = H1, l2 = H2;
            int sum = 0, carry = 0;
            while(l1 != null || l2 != null || carry != 0)
            {
                sum = 0;
                if(l1!=null)
                {
                    sum += l1.val;
                    l1 = l1.Next;
                }
                if(l2!=null)
                {
                    sum += l2.val;
                    l2 = l2.Next;
                }

                sum += carry;
                carry = sum / 10;
                Node N = new Node(sum % 10);
                temp.Next = N;
                temp = temp.Next;
            }
            return dumy.Next;
        }
    }
}
