using System;
using System.Collections.Generic;
using System.Text;

namespace BinarniStrom
{
    /// <summary>
    /// Simple implementation of Linked List
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SimpleLinkedList<T> where T : IComparable
    {
        public SimpleLinkedListNode<T> head;

        public void Add(T item)
        {
            SimpleLinkedListNode<T> node = new SimpleLinkedListNode<T>(item);
            if (head == null)
            {
                head = node;
            }
            else
            {
                var current = head;
                while (current.Next != null) current = current.Next;
                current.Next = node;
            }
        }
        public SimpleLinkedList<T> Swap(SimpleLinkedList<T> Node)
        {
            var current = Node.head;
            SimpleLinkedList<T> answerList = new SimpleLinkedList<T>();
            while(current.Next != null)
            {
                answerList.AddToStart(current.value);
                current = current.Next;
            }
            answerList.AddToStart(current.value);
            return answerList;
        }
        public void AddToStart(T item)
        {
            SimpleLinkedListNode<T> node = new SimpleLinkedListNode<T>(item);
            node.Next = head;
            head = node;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SimpleLinkedListEnumerator<T>(this);
        }
    }
    
    /// <summary>
    /// Node of SimpleLinkedList
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SimpleLinkedListNode<T> where T : IComparable
    {
        internal T value;
        internal SimpleLinkedListNode<T> Next { get; set; }

        public SimpleLinkedListNode(T value)
        {
            this.value = value;
        }
    }

    /// <summary>
    /// Enumerator for browsing LinkedList
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SimpleLinkedListEnumerator<T> : IEnumerator<T> where T : IComparable
    {
        protected SimpleLinkedListNode<T> _current;
        protected SimpleLinkedList<T> _list;

        public SimpleLinkedListEnumerator(SimpleLinkedList<T> list)
        {
            _list = list;
            Reset();
        }

        public object Current
        {
            get
            {
                return _current.value;
            }
        }

        T IEnumerator<T>.Current { get { return _current.value; } }

        public void Dispose() { }

        public bool MoveNext()
        {
            if (_current == null && _list.head != null)
            {
                _current = _list.head;
            }
            else if (_current == null)
            {
                return false;
            }
            else
            {
                _current = _current.Next;
            }
            if (_current == null) return false;
            return true;
        }

        public void Reset()
        {
            _current = null;
        }
    }
}
