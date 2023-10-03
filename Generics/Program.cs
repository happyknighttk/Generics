using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Adana");
            sehirler.Add("Istanbul");
            sehirler.Add("Antalya");

            Console.WriteLine(sehirler.Count);


            Mylist<string> sehirler2 = new Mylist<string>();
            sehirler2.Add("İstanbul");
            sehirler2.Add("Ankara");
            sehirler2.Add("Elazığ");
            sehirler2.Add("Antalya");
            sehirler2.Add("Sivas");
            sehirler2.Add("Çorum");
            sehirler2.Add("Kocaeli");

            Console.WriteLine(sehirler2.Count);

        }
    }
    class Mylist<T> //Generic Class
    {
        T[] _array;
        T[] _tempArray;

        public Mylist() { 
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length+1];
            for (int i = 0; i < _tempArray.Length;  i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length-1] = item;
        }
        public int Count
        {
            get { return _array.Length; } 
        }
    }
}
