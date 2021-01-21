using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Begüm");
            myDictionary.Add("Mert");
            myDictionary.Add("Tuana");
        }
    }
}
