using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableLinkedList
{
    public class MyHashMapNode<k, v>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<k, v>>[] item;
        public MyHashMapNode(int size)
        {
            this.size=size;
            this.item=new LinkedList<KeyValue<k,v>>[size];

        }
        protected int GetArrayPossition(k key)
        {
            int possition = key.GetHashCode() % size;
            return Math.Abs(possition);
        }

        public void add(k key,v value)
        {
            int possition = GetArrayPossition(key);
            LinkedList<KeyValue<k, v>> linkedList = GetLinkedList(possition);
            KeyValue<k, v> item = new KeyValue<k, v>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }

        public void Remove(k key)
        {
            int possition = GetArrayPossition(key);
            LinkedList<KeyValue<k, v>> linkedList = GetLinkedList(possition);
            bool itemFound = false;
            KeyValue<k, v> Founditem =  default(KeyValue<k, v>);
            foreach(KeyValue<k, v> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    Founditem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(Founditem);
            }
        }
        public void find(k key)
        {
            int possition = GetArrayPossition(key);
            LinkedList<KeyValue<k, v>> linkedList = GetLinkedList(possition);
            bool itemFound = false;
            KeyValue<k, v> Founditem = default(KeyValue<k, v>);
            foreach (KeyValue<k, v> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    Founditem = item;
                }
            }
            if (itemFound)
            {
                Console.WriteLine(linkedList.Find(Founditem));
            }
        }
        public v Get(k key)
        {
            int possition = GetArrayPossition(key);
            LinkedList<KeyValue<k, v>> linkedList = GetLinkedList(possition);
            foreach(KeyValue<k,v> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(v);
        }
        protected LinkedList<KeyValue<k,v>>GetLinkedList(int position)
        {
            LinkedList<KeyValue<k, v>> linkedList = item[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<k, v>>();
                item[position] = linkedList;
            }
            return linkedList;
        }
    }
    public struct KeyValue<k, v>
    {
         public k Key { get; set; }
         public v Value { get; set; }

    }
}