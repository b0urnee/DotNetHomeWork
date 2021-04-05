using System;

namespace GenericList
{

    class Program
    {
        static void Main(string[] args)
        {
            //整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int i = 0; i < 5; i++)
            {
                intlist.Add(i);
            }

            int sum = 0;
            Action<int> action = delegate (int item)
            {
                Console.WriteLine(item);
                sum = sum + item;
            };
            intlist.ForEach(action);
            Console.WriteLine("sum={0}", sum);
            
            int max = -100, min = 100;

            intlist.ForEach(x => { if (x > max) max = x; });//最大值
            intlist.ForEach(x => { if (x < min) min = x; });//最小
            Console.WriteLine("max ={0}\nmin={1}", max, min);                                              //值
        }


        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Data { get; set; }

            public Node(T t)
            {
                Next = null;
                Data = t;
            }
        }

        public class GenericList<T>
        {
            private Node<T> head;
            private Node<T> tail;

            public GenericList()
            {
                tail = head = null;
            }

            public Node<T> Head
            {
                get => head;
            }
            public void Add(T t)
            {
                Node<T> n = new Node<T>(t);
                if (tail == null)
                {
                    head = tail = n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                }
            }
            public void ForEach(Action<T> action)
            {
                Node<T> t = head;
                while (t != null)
                {
                    action(t.Data);
                    t = t.Next;
                }
            }
        }
    } 
}
