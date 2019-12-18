using System;
using System.Collections.Generic;
using System.Text;

namespace BinarniStrom
{
    class MyDictionary<K, V> where K : IComparable where V : IComparable
    {
        public void Add(K key, V value)
        {
            var newNode = new Node() { Key = key, Value = value, Left = null, Right = null };
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Insert(root, newNode);
            }
            /*
            if(root.Key.Equals(key))
            {
                new Exception("tento klíč už existuje");
            }
            else if(key.ToString().CompareTo(root.Key.ToString()) < 0)
            {
                if(root.Left == null)
                {
                    root.Left = newNode;
                }
                else
                {
                    Insert(root.Left, newNode);
                }
            }
            else
            {
                if(root.Right == null)
                {
                    root.Right = newNode;
                }
                else
                {
                    Insert(root.Right, newNode);
                }
            }*/
        }
        public void Insert(Node side, Node newnode)
        {
            if (side.Key.Equals(newnode.Key))
            {
                throw new Exception("Tento klíč už existuje");
            }
            else if (side.Key.CompareTo(newnode.Key) > 0)
            {
                if (side.Left == null)
                {
                    side.Left = newnode;
                }
                else
                {
                    Insert(side.Left, newnode);
                }
            }
            else
            {
                if (side.Right == null)
                {
                    side.Right = newnode;
                }
                else
                {
                    Insert(side.Right, newnode);
                }
            }
        }
        public V Min
        {
            get
            {
                if(root == null)
                {
                    throw new System.ArgumentException("Žádný uzel");
                }
                else
                {
                    return Minimum(root);
                }
            }
        }
        public V Max
        {
            get
            {
                if(root == null)
                {
                    throw new System.ArgumentException("Žádný uzel");
                }
                else
                {
                    return Maximum(root);
                }
            }
        }
        public V Minimum(Node node)
        {
            if(node.Left!= null)
            {
                return Minimum(node.Left);
            }
            return node.Value;
        }
        public V Maximum(Node node)
        {
            if(node.Right!= null)
            {
                return Maximum(node.Right);
            }
            return node.Value;
        }
        public int Count
        {
            get
            {
                if (root == null)
                {
                    return pocet;
                }
                pocet++;
                return pocitej(root);
            }
        }
        int pocet = 0;
        public int pocitej(Node node)
        {
            if(node.Left != null)
            {
                pocet += 1;
                pocitej(node.Left);
            }
            if(node.Right != null)
            {
                pocet += 1;
                pocitej(node.Right);
            }
            return pocet;
        }
        public override string ToString()
        {
            string temp = "";
            if (root != null)
            {
                temp = temp + " " + ToStryng(root);
            }
            return temp;
            /*
            string result = "";
            Node pointer = root;
            if (pointer.Left != null)
            {
                result = result + ToStryng(pointer.Left);
            }
            result = result + pointer.Value.ToString();
            if (pointer.Right != null)
            {
                result = result + ToStryng(pointer.Right);
            }
            result = result + pointer.Value.ToString();
            return result;*/
        }
        public string ToStryng(Node node)
        {
            string result = "";
            Node pointer = node;
            if(pointer.Left != null)
            {
                result += ToStryng(pointer.Left) + " ";
            }
            result += pointer.Value.ToString() + " ";
            if(pointer.Right != null)
            {
                result += ToStryng(pointer.Right) + " ";
            }
            //result = result + pointer.Value.ToString();
            return result;
        }
        private Node root;
        public MyDictionary()
        {
            root = null;
        }
        internal class Node
        {
            public K Key;
            public V Value;
            public Node Left;
            public Node Right;
        }
    }
}
