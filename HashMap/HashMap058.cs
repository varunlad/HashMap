using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMapNode
{

    public class MyMapNode<K, V>
    {
        //this method is for passing Keyvalues in linkedlist k,v are data types
        //Created a class for key,value pair.
        public struct KeyValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        //created a Constructor to initialize the variables.
        public MyMapNode(int size)
        {
            this.size = size; //this- is used to refer current class variables.
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        //Method to find the position of the hash table(creating hash code)
        protected int GetArrayPosition(K Key)
        {
            int hash = Key.GetHashCode();

            //%---> will give th mod value. So I used Math.Abs to find the interger of it.
            int position = hash % size;
            return Math.Abs(position);
        }

        //method to get a value stored in particular key
        // It is to Identify the array position at what Index particular key is located.
        public V Get(K Key) // Its a Generic method.
        {
            int position = GetArrayPosition(Key);

            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(Key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        //method for to add values in hashtable
        //It is just performing the operation.Iam just pushing the data into the hashtable using linked list operation.
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>()
            //assign values to Key and Value
            { Key = key, Value = value };
            if (linkedList.Count != 0)
            {
                foreach (KeyValue<K, V> item1 in linkedList)
                {
                    if (item1.Key.Equals(key))
                    {
                        break;
                    }
                }
            }
            linkedList.AddLast(item);
        }

        //created a method to find the exist key in particular position.
        public bool ExistKey(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }


        //GetLinkedList method to create a linkedlist and store the values in that list. 
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        // CountFrequency method is to count the frequencies of word in hash table.
        public void CountFrequency(string sentence)
        {
            MyMapNode<string, int> myHashTable = new MyMapNode<string, int>(10);
            string[] words = sentence.ToLower().Split(' ');
            foreach (string word in words)
            {
                if (myHashTable.ExistKey(word))
                {
                    myHashTable.Add(word, myHashTable.Get(word) + 1);
                }
                else
                {
                    myHashTable.Add(word, 1);
                }
            }
            Console.WriteLine("Display frequencies of words");
            myHashTable.Display();
        }

        //method to display the elements in the hash table.
        public void Display()
        {
            foreach (var linkedList in items)
            {
                if (linkedList != null)
                    foreach (var element in linkedList)
                    {
                        string res = element.ToString();
                        if (res != null)
                            Console.WriteLine(element.Key + " " + element.Value);
                    }
            }
        }
    }
}
