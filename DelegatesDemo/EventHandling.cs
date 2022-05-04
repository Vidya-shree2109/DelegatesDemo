﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate void EventHandler(string x);
    public class EventHandling
    {
        public class Operation
        {
            public event EventHandler xyz;
            public void Action(string a)
            {
                if(xyz != null)
                {
                    xyz(a);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }
        private static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }
        public static void ImplementEvent()
        {
            Operation o = new Operation();
            o.Action("Event Calling");
            Console.WriteLine();
            o.xyz += new EventHandler(CatchEvent);
            o.Action("Event Called");
        }
    }
}