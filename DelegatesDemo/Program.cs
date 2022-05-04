using System;
namespace DelegatesDemo;
public class Program
{
    //public delegate int Operation(int x, int y);

    //public static int Addition(int x, int y)
    //{
    //    return x + y;
    //}
    //public static void Main(String[] args)
    //{
        //Operation obj = new Operation(Addition);
       //Console.WriteLine("Addition of the two numbers is " + obj(51, 10));

    //}
    public static void Main(String[] args)
    {
        MulticastDelegate.ImplementDelegate();
        EventHandling.ImplementEvent();
    }
}