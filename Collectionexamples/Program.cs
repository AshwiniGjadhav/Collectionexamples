using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collectionexamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*Stack stack = new Stack();
            stack.Push(20);
            stack.Push(40);
            stack.Push(23);
            stack.Push(4);
            stack.Push(50);

            stack.Pop();
            stack.Peek();
            Console.WriteLine(stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Queue q=new Queue();
            q.Enqueue(20);
            q.Enqueue(300);
            q.Enqueue(100);
            q.Dequeue();

            Console.WriteLine("\n " + q.Peek()); 
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }*/

            Hashtable ht=new Hashtable();

            ht.Add(91, "India");
            ht.Add(1, "USA");
            ht.Add(33, "FR");
            ht.Add(63, "AUS");

            ht.Remove(33);
            Console.WriteLine("\n");
            foreach (DictionaryEntry d in ht)
            {
                
                Console.WriteLine($"{d.Key}  {d.Value}");
            }
        }
    }
}
