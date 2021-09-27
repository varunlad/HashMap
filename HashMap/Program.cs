using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMapNode
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling a MyMapNode class.
            MyMapNode<string, string> hash = new MyMapNode<string, string>(6);
            hash.Add("1", "To");
            hash.Add("2", "be");
            hash.Add("3", "or");
            hash.Add("4", "not");
            hash.Add("5", "to");
            hash.Add("6", "be");
            string hash6 = hash.Get("6");
            Console.WriteLine("6th index value:" + hash6);
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value:" + hash5);
            string hash4 = hash.Get("4");
            Console.WriteLine("4th index value:" + hash4);
            string hash3 = hash.Get("3");
            Console.WriteLine("3th index value:" + hash3);
            string hash2 = hash.Get("2");
            Console.WriteLine("2th index value : " + hash2);
            string hash1 = hash.Get("1");
            Console.WriteLine("1th index value : " + hash1);
            //Calling Count Frequency Method.
            hash.CountFrequency("To be or not to be");

            Console.ReadLine();
        }
    }
}
