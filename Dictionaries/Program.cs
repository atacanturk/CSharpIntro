using System;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Deniz");
            myDictionary.Add(2, "Ata");

            Console.WriteLine(myDictionary.writeKey[0]); //myDictionary'de birinci elemanın key'ini verir
            Console.WriteLine(myDictionary.writeValue[0]);

            Console.WriteLine("============");

            Console.WriteLine(myDictionary.writeKey[1]);//myDictionary'de ikinci elemanın key'ini verir
            Console.WriteLine(myDictionary.writeValue[1]);

        }
    }
}
