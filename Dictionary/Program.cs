using System;
using System.Collections.Generic;


namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> ligSıralamsı = new Dictionary<int, string>();
            //ligSıralamsı.Add(44, "Besiktas");
            //Console.WriteLine(ligSıralamsı.Count);

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.add(44, "Besiktas");
            myDictionary.add(43, "Fenerbahçe");
            myDictionary.add(40, "Galatasaray");
            myDictionary.add(44, "Besi");
            myDictionary.add(43, "rbahçe");
            myDictionary.add(40, "Galatay");

            Console.WriteLine(myDictionary.count);
       
         


        }

        class MyDictionary<T, A>

        {
            T[] _array;
            A[] array;
            T[] _tempArray;
            A[] tempArray;
            public MyDictionary()
            {
                _array = new T[0];
                array = new A[0];

            }
            public void add(T Key, A Value)
            {
                _tempArray = _array;
                tempArray = array;
                _array = new T[_array.Length + 1];
                array = new A[array.Length + 1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                for (int i = 0; i < tempArray.Length; i++)
                {
                    array[i] = tempArray[i];
                }
                _array[_array.Length - 1] = Key;
                array[array.Length - 1] = Value;
            }

            public int count
            {
                get { return array.Length; int Length = _array.Length; }

            }
        }
    }
}
