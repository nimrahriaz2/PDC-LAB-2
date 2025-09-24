using System;
using System.Threading;
class Program
{
    static void Main()
    {
        string line = "----------------";
        int length = line.Length;
        for (int i = 0; i < length; i++) {
            Console.WriteLine('\r' + new string(' ', i) + "C" + line.Substring(i + 1));
            Thread.Sleep(200);
            Console.WriteLine('\r' + new string(' ', i) + "C" + line.Substring(i + 1));
            Thread.Sleep(200);


        }
        Console.WriteLine('\r' + new string(' ', length + 'C'));
        Console.WriteLine("\n \nGame Over! Pac-Man ate all dots");


    }
}
