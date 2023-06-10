using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<H>: INode<H> 
    {
        private H content;

        private List<Node<H>> children = new List<Node<H>>();

        public H Content 
        {
            get
            {
                return this.content;
            }
        }

        public ReadOnlyCollection<Node<H>> Children 
        { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(H h)
        {
            this.content = h;
        }

        public void AddChildren(Node<H> n)
        {
            this.children.Add(n);
        }

        public void accept(IVisitor<H> visitor){
            visitor.Visit(this);
        }
        
    }
}