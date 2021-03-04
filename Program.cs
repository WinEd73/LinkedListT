using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine("Esta vacia? - " + list.Empty);
            
            list.Add("1");
            list.Add("2");
            list.Add("3");


        }
    }
}
