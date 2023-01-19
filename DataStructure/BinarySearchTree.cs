using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }

        int leftCount = 0;
        int rightCount = 0;

        public void Add(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree<T>(item);
                    leftCount++;
                }
                else
                {
                    this.LeftTree.Add(item);
                    leftCount++;
                    return;
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BinarySearchTree<T>(item);
                    rightCount++;
                }
                else
                {
                    this.RightTree.Add(item);
                    rightCount++;
                    return;
                }
            }
            Console.WriteLine($"Added : {item}");
        }

        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.LeftTree.Display();
            }
            Console.Write(this.NodeData.ToString() + " ");
            if (this.RightTree != null)
            {
                this.RightTree.Display();
            }
        }

        public void Size()
        {
            Console.WriteLine($"\n\nSize of Binary Tree : {(1 + leftCount + rightCount)}");
        }
        public BinarySearchTree<T> FindElement(T element, BinarySearchTree<T> node)
        {
            if (node != null)
            {
                if (element.Equals(node.NodeData))
                {
                    return node;
                }
                if (element.CompareTo(node.NodeData) < 0)
                {
                    return FindElement(element, node.LeftTree);
                }
                else
                {
                    return FindElement(element, node.RightTree);
                }
            }
            return null;
        }
    }
}


