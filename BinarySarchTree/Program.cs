using System;

namespace BinarySarchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree obj = new BinaryTree();

            obj.Add(56);
            obj.Add(30);
            obj.Add(70);
            obj.Add(10);
            obj.Add(22);
            obj.Add(40);
            obj.Add(60);
            obj.Add(95);
            obj.Add(11);
            obj.Add(65);
            obj.Add(3);
            obj.Add(16);
            obj.Add(67);
            obj.Add(63);


            obj.size();
            obj.search(63);

        }
    }
}
