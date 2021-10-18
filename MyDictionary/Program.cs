using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            myDictionary<string> myName = new myDictionary<string>();
            myName.Add("Tunahan");
            Console.WriteLine(myName.Count);
            Console.ReadKey(); 
        }
        //generic class
        class myDictionary<T>
        {
            T[] tArray;
            T[] Array;
            public void MyProperty()
            {
                Array = new T[0];
            }
            public void Add(T item)
            {
                tArray = Array;
                Array = new T[Array.Length + 1];
                for (int i = 0; i < tArray.Length; i++) 
                {
                    Array[i] = tArray[i];
                }
                Array[Array.Length - 1] = item;
            }
            public int Count 
            {
                get { return Array.Length; }
            }
        }
    }
}
