using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{


    public class ListNode
    {
        public int val;
        public ListNode next;


        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        //1
        //1 2 4
        public void AddItemToList(int val)
        {
            ListNode aux = this;
            if (aux.next == null)
            {
                if (aux.val > val)
                {
                    var off = new ListNode(val, aux);

                }
                else
                {
                    aux.next = new ListNode(val);
                }
            }
            else
            {
                while (aux != null)
                {
                    if (aux.next.val < val)
                    {
                        if(aux.next == null)
                        {
                            aux.next = new ListNode(val);
                        }
                        else
                        {
                            aux = aux.next;
                        }
                    }
                    else
                    {
                        var off = new ListNode(val, aux.next);
                        aux.next = off;
                    }
                }
            }
        }
    }

    public class SolutionMergeTwoLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode head = list1;
            ListNode aux = list2;
            while (list2.next != null)
            {
                head.AddItemToList(aux.val);
                aux = aux.next;
            }
            return head;
        }
    }

}
