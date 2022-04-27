using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    internal class Node<T>
    {
        public T data; 
        public Node<T> next; // declaring a next node
        public Node(T data) // Crating constructor havind node data as parameter
        {
            this.data = data;
        }
    }
}
