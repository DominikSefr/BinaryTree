using System;
using System.Collections.Generic;
using System.Text;

namespace BinarniStrom
{
    /// <summary>
    /// Simple implementation of Binary Tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SimpleBinaryTree<T> where T : IComparable
    {
        protected SimpleBinaryTreeNode<T> _root = null;
        private T tempScore { get; set; }
        private List<T> tempHigh { get; set; }
        public void Add(T item)
        {
            Add(item, ref _root);
        }
        public T Max()
        {
            var tempNode = _root;
            if (tempNode.left != null)
            {
                tempScore = tempNode.left.value;
                if (tempScore.CompareTo(_root.value) == 1)
                {
                    tempScore = tempNode.left.value;
                    Max(tempNode.left);
                }
                else
                {
                    Max(tempNode.left);
                }
            }
            if (tempNode.right != null)
            {
                tempScore = tempNode.right.value;
                if (tempScore.CompareTo(_root.value) == 1)
                {
                    tempScore = tempNode.right.value;
                    Max(tempNode.right);
                }
                else
                {
                    Max(tempNode.right);
                }
            }
            return tempScore;
        }
        public T Max(SimpleBinaryTreeNode<T> Node)
        {

            var tempNode = Node;
            if (tempNode.left != null)
            {
                tempScore = tempNode.left.value;
                if (tempScore.CompareTo(_root.value) == 1)
                {
                    tempScore = tempNode.left.value;
                    Max(tempNode.left);
                }
                else
                {
                    Max(tempNode.left);
                }
            }
            if (tempNode.right != null)
            {
                tempScore = tempNode.right.value;
                if (tempScore.CompareTo(_root.value) == 1)
                {
                    tempScore = tempNode.right.value;
                    Max(tempNode.right);
                }
                else
                {
                    Max(tempNode.right);
                }
            }
            return tempNode.value;
        }
        public List<T> Overfifty()
        {
            var tempNode = _root;
            var obj = new Applicant { Score = 50 };
            if (tempNode.left != null)
            {
                if (tempNode.left.value.CompareTo(obj) == 1)
                {
                    tempHigh.Add(tempNode.left.value);
                    Overfifty(tempNode.left);
                }
                else
                {
                    Overfifty(tempNode.left);
                }
            }
            if (tempNode.right != null)
            {
                if (tempNode.right.value.CompareTo(obj) == 1)
                {
                    tempHigh.Add(tempNode.right.value);
                    Overfifty(tempNode.right);
                }
                else
                {
                    Overfifty(tempNode.right);
                }
            }
            return tempHigh;
        }
        public List<T> Overfifty(SimpleBinaryTreeNode<T> Node)
        {
            var tempNode = Node;
            var obj = new Applicant { Score = 50 };
            if (tempNode.left != null)
            {
                if (tempNode.left.value.CompareTo(obj) == 1)
                {
                    tempHigh.Add(tempNode.left.value);
                    Overfifty(tempNode.left);
                }
                else
                {
                    Overfifty(tempNode.left);
                }
            }
            if (tempNode.right != null)
            {
                if (tempNode.right.value.CompareTo(obj) == 1)
                {
                    tempHigh.Add(tempNode.right.value);
                    Overfifty(tempNode.right);
                }
                else
                {
                    Overfifty(tempNode.right);
                }
            }
            return tempHigh;
        }
        protected void Add(T item, ref SimpleBinaryTreeNode<T> node)
        {
            if (node == null)
            {
                node = new SimpleBinaryTreeNode<T>(item);
            }
            else if (item.CompareTo(node.value) == -1)
            {
                Add(item, ref node.left);
            }
            else
            {
                Add(item, ref node.right);
            }
        }

        public override string ToString()
        {
            return TreeToString(_root);
        }

        protected string TreeToString(SimpleBinaryTreeNode<T> node)
        {
            if (node == null) return "";
            return TreeToString(node.left) + node.value + TreeToString(node.right);
        }

        public SimpleBinaryTreeNode<T> Find(T item)
        {
            return Find(item, _root);
        }

        protected SimpleBinaryTreeNode<T> Find(T item, SimpleBinaryTreeNode<T> node)
        {
            if (node != null)
            {
                if (item.CompareTo(node.value) == 0)
                {
                    return node;
                }
                else if (item.CompareTo(node.value) == -1)
                {
                    return Find(item, node.left);
                }
                else
                {
                    return Find(item, node.right);
                }
            }
            return null;
        }

    }

    /// <summary>
    /// Node of Binary Tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SimpleBinaryTreeNode<T> where T : IComparable
    {
        internal T value;

        public SimpleBinaryTreeNode(T value)
        {
            this.value = value;
        }

        internal SimpleBinaryTreeNode<T> left;
        internal SimpleBinaryTreeNode<T> right;
    }
}
