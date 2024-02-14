using System;
class HelloWorld
{
    public static void Main(string[] args) 
    {
        int a = 5;
        int b = 7;
        //program to interchange variables
        int temp = a;
        b = a;
        temp = b;
        Console.WriteLine("a is :" + a + "b is :" + b );
    }
}

