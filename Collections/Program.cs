using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListClass();
            Console.WriteLine();
            HashSetClass();
            Console.WriteLine();
            SortedSetClass();
            Console.WriteLine();
            StackClass();
            Console.WriteLine();
            QueueClass();
            Console.WriteLine();
            LinkedListClass();
            Console.WriteLine();
            DictionaryClass();
            Console.WriteLine();
            SortedDictionaryClass();
            Console.WriteLine();
            SortedListClass();

        }

        public static void ListClass()
        {
            var name = new List<string>();  //{"a", "b", "c"};

            name.Add("a");
            name.Add("b");
            name.Add("c");
            name.Add("a");  // duplicate allow

            Console.WriteLine("List class");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }


        public static void HashSetClass()
        {
            var name = new HashSet<string>(); // {"a", "b", "c"};

            name.Add("a");
            name.Add("b");
            name.Add("c");
            name.Add("a");  // not all duplicate

            Console.WriteLine("HashSet class");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }


        public static void SortedSetClass()
        {
            var name = new SortedSet<string>();  // {"a", "b", "c"};

            name.Add("d");
            name.Add("b");
            name.Add("a");
            name.Add("c");
            name.Add("a");  // not allow duplicate

            Console.WriteLine("Sorted set class ascending order follow");

            foreach(var item in name)
            {
                Console.WriteLine(item);
            }
        }


        public static void StackClass()
        {
            var name = new Stack<string>();

            name.Push("a");
            name.Push("b");
            name.Push("c");
            name.Push("d");
            name.Push("b");  // duplicate allow

            Console.WriteLine("Stack class LIFO order");
            
            foreach( var item in name)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Peek : " + name.Peek());
            Console.WriteLine("Pop : " + name.Pop());
            Console.WriteLine("After pop, peek : " + name.Peek());

        }


        public static void QueueClass()
        {
            var name = new Queue<string>();

            name.Enqueue("a");
            name.Enqueue("b");
            name.Enqueue("c");
            name.Enqueue("d");
            name.Enqueue("b");  // allow duplicate

            Console.WriteLine("Queue class FIFO order");
            foreach ( var item in name)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Peek : " + name.Peek());
            Console.WriteLine("Dequeue: " + name.Dequeue());
            Console.WriteLine("After dequeue, peek: " + name.Peek());

        }


        public static void LinkedListClass()
        {
            var name = new LinkedList<string>();

            name.AddLast("a");
            name.AddLast("b");
            name.AddLast("c");
            name.AddLast("d");  // allow duplicate
            name.AddFirst("d");  // added to first

            Console.WriteLine("LinkedList class");

            foreach ( var item in name)
            {
                Console.WriteLine(item);
            }

            LinkedListNode<string> node = name.Find("b");
            name.AddAfter(node, "ee");
            name.AddBefore(node, "ff");

            Console.WriteLine("After adding before and after");
            foreach ( var item in name)
            {
                Console.WriteLine(item);
            }

        }


        public static void DictionaryClass()
        {
            Dictionary<int, string> name = new Dictionary<int, string>();

            name.Add(1, "a");
            name.Add(2, "b");
            name.Add(3, "c");
            name.Add(4, "d");
            name.Add(5, "a");   // not allow duplicate key but allow duplicate value

            Console.WriteLine("Dictionary class");
            Console.WriteLine("key   Value");
            foreach ( KeyValuePair<int, string> item in name)
            {
                Console.WriteLine(item.Key + "      " + item.Value);
            }
        }


        public static void SortedDictionaryClass()
        {
            SortedDictionary<string, string> name = new SortedDictionary<string, string>();

            name.Add("2", "b");
            name.Add("4", "d");
            name.Add("3", "c");
            name.Add("1", "a");
            name.Add("5", "a");  // allow duplicate value but not allow duplicate key

            Console.WriteLine("SortedDictionary class follow ascending order by key");

            foreach ( KeyValuePair<string, string> item in name)
            {
                Console.WriteLine(item.Key + "   " + item.Value);
            }

        }


        public static void SortedListClass()
        {
            SortedList<int, string> name = new SortedList<int, string>();

            name.Add(2, "b");
            name.Add(1, "a");
            name.Add(4, "d");
            name.Add(3, "c");
            name.Add(5, "a");   //allow duplicate value but not allow duplicate key

            Console.WriteLine("SortedList class follow ascending order by key");
            foreach ( KeyValuePair<int, string> item in name)
            {
                Console.WriteLine(item.Key + "   " + item.Value);
            }
        }
    }
}
