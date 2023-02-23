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

        public void PrintList(ListNode head)
        {
            ListNode aux = head;
            while(aux !=  null)
            {
                Console.WriteLine(aux.val);
                aux = aux.next;
            }
        }

        public void AddItemToList(int val)
        {
            ListNode aux = this;
            while (aux.next != null)
            {
                aux = aux.next;
            }
            aux.next = new ListNode(val);
        }


    }

    public class SolutionMergeTwoLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode head = list1.next;
            return head;
        }
    }

}
