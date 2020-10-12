using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_GenericLinkedList
{
    public class Node<T>
    {
        private Node<T> next;
        private T data;

        public Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public Node(T t)
        {
            next = null;
            data = t;
        }
    }
     public class GenericLinkerList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericLinkerList()
        {
            tail = head = null;
        }

        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if(tail == null)
            {
                head = node;
                tail = node;

            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }

        public void ForEach(Action<T> action)
        {
            for(Node<T> node=head;node!=null;node=node.Next)
            {
                action(node.Data);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            GenericLinkerList<int> list = new GenericLinkerList<int>();
            for(int i=0;i<16;i++)
            {
                list.Add(random.Next(1, 101));
            }
            list.ForEach(n => Console.Write(n+" "));
            Console.WriteLine();

            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            int sum = 0;
            list.ForEach(n =>
                {
                    min = (n < min) ? n : min;
                    max = (n > max) ? n : max;
                    sum += n;
                }
                );
            Console.WriteLine($"最小值:{min},最大值:{max},和:{sum}");
        }
    }
}
