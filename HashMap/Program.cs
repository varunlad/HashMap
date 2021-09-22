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
            MyMapNode<string, string> hash = new MyMapNode<string, string>(6);
            hash.Add("1", "To");
            hash.Add("2", "be");
            hash.Add("3", "or");
            hash.Add("4", "not");
            hash.Add("5", "to");
            //Console.WriteLine(hash.FrequencyOfWords("be"));
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value:" + hash5);
            //hash.Remove("2");
            string hash2 = hash.Get("2");
            Console.WriteLine("2th index value : " + hash2);
            Console.WriteLine(hash.FrequencyOfWords("be"));
            Console.ReadLine();
        }
    }
}
