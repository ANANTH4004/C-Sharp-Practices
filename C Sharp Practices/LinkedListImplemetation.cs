using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    public class node
    {
        public string data;
        public node next;
        public node(string data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class LinkedListImplemetation
    {
        public node head;
        public void InsertFront(LinkedListImplemetation link , string data)
        {
            node newNode = new node(data);
            newNode.next = link.head;
            link.head = newNode;
        }
        public void InsertLast(LinkedListImplemetation link , string data)
        {
            node newnode = new node(data);
            if(link.head == null)
            {
                link.head = newnode;
                return;
            }
            node lastNode = GetLastNode(link);
            lastNode.next = newnode;

        }
        public node GetLastNode(LinkedListImplemetation link)
        {
            node temp = link.head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void PrintList(LinkedListImplemetation link)
        {
            node temp = link.head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void Reverse(LinkedListImplemetation link)
        {
            node prev = null;
            node curr = link.head;
            node next1 = null;
            while (curr !=  null)
            {
                next1 = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next1;
            }
            link.head = prev;

        }
        public void Insert(LinkedListImplemetation link, int pos)
        {
            node temp = link.head;
            while (pos-1 > 1)
            { 
                pos--;
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
            try
            {
                node newnode = null;
                newnode.data = Console.ReadLine();
                temp.next = newnode;
                newnode.next = temp.next;
            }catch(Exception ex)
            {
                Console.WriteLine("Exception message : " + ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}
