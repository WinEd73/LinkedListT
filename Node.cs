using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node 
    {
    private int data;
    private Node Previous;
    private Node next;


 public Node(int data, Node next, Node Previous){
    this.data = data;
    this.next = next;
    this.Previous = Previous;
}

    public int Data 
    {
        get { return this.data;}
        set {this.data = value;}

    }

    public Node Next
    {
        get {return this.next;}
        set{this.next = value;}
        
    }

    public Node previous
    {
        get {return this.previous;}
        set{this.next = value;}
    }
    }
}