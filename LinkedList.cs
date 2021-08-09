using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class LinkedList
    {
    }

    public class Node
    {
        public int info { get; set; } // info = data

        public Node node { get; set; } //  next node.

        public Node(int i )
        {
            this.info = i;  
            this.node = null;  // next node will be null begining of the initialization
        }


    }
}
