using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySarchTree
{
    class BinaryTree
    {
        public Node Root { get; set; }
        public bool Add(int value)
        {
            Node temp1 = null, temp2 = this.Root;
            while (temp2 != null)
            {
                temp1 = temp2;
                if (value < temp2.Data)
                {
                    temp2 = temp2.LeftNode;
                }
                else if (value > temp2.Data)
                {
                    temp2 = temp2.RightNode; 
                }
                else
                {
                    return false;
                }
            }
            Node node = new Node();
            node.Data = value;
            if (this.Root == null)
            {
                this.Root = node;
            }
            else
            {
                if (value < temp1.Data)
                {
                    temp1.LeftNode = node;
                    Console.WriteLine("left node is added " + temp1.Data);
                }
                else
                { temp1.RightNode = node;
                    Console.WriteLine("right node is added " + temp1.Data);
                }
            }
            return true;
        }

        public void search(int num)
        {
            searching(Root,num);

        }

        public void size()
        {
            int num=find(Root);
            Console.WriteLine("size of Binary Tree is: " + count);
            int find(Node Parent){
                if (Parent != null)
                {
                    find(Parent.LeftNode);
                    find(Parent.RightNode);
                    count++;
                }
                return count;
            }
        }
        public int count=0;
        public int searching(Node value,int num)
        {
            if (value != null)
            {
                if (value.Data == num)
                {
                    Console.WriteLine("Data found"+value.Data);
                }
                //Console.WriteLine(value.Data + " ");
                searching(value.LeftNode,num);
                searching(value.RightNode,num);
                count++;
            }
            return count;
        }
    }
}
