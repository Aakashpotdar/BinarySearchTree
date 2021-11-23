using System;
using System.Collections;

namespace HashTableLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashMapNode<string, string> obj = new MyHashMapNode<string, string>(5);
            obj.add("0", "to");
            obj.add("1", "be");
            obj.add("2", "or");
            obj.add("3", "not");
            obj.add("4", "to");
            obj.add("5", "be");
            string name = obj.Get("4");

            Console.WriteLine("the 4th index data is: " + name);

            string name1 = obj.Get("2");

            Console.WriteLine("the 2nd index data is: " + name1);

            


        }
    }
}
