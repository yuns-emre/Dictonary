using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string,int> myDictonary = new MyDictonary<string,int>();
            myDictonary.Add("Amy",8);
            myDictonary.Add("Jake", 5);
            myDictonary.Add("Terry", 10);

            Console.WriteLine(myDictonary.CountKey);
            Console.WriteLine(myDictonary.CountValue);
        }
    }
}
