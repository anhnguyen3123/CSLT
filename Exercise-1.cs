using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Transactions;

internal class BT_Buoi1
{
    private static void Main(string[] args)
    {
        //BT1();
        //BT2();
        //BT3();
        //BT4();
        //BT5();
        //BT6();
        //BT7();
        //BT8();
        //BT8_2();
        //BT9();
        BT10();
    }

    static void BT1()
    {
        int number_1;
        int number_2;
        int total;
        Console.Write("enter number 1 here: ");
        number_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter number 2 here: ");
        number_2 = Convert.ToInt32(Console.ReadLine());
        total = number_1 + number_2;
        Console.WriteLine($"your total of {number_1} and {number_2} is: " + total);
    }

    static void BT2()
    {
        Console.Write("your vari_1 is: ");
        string vari_1 = Console.ReadLine();
        Console.Write("your vari_2 is: ");
        string vari_2 = Console.ReadLine();
        string temp;
        temp = vari_1;
        vari_1 = vari_2;
        vari_2 = temp;

        Console.WriteLine($"your vari_1 is now {vari_1} and your vari_2 is now {vari_2}");
        Console.WriteLine("SWAP complete!");
    }

    static void BT3()
    {
        Console.Write("your floating number 1 is? ");
        float float_1 = float.Parse(Console.ReadLine());
        Console.Write("your floating number 2 is? ");
        float float_2 = float.Parse(Console.ReadLine());
        float mul = float_1 * float_2;
        Console.WriteLine($"your multiplied value between {float_1} and {float_2} is " + mul);
    }

    static void BT4()
    {
        Console.Write("your feet value is: ");
        float feet = float.Parse(Console.ReadLine());
        float meter = feet * 0.3048f;
        Console.WriteLine("your converted value from feet => meter is {0}", meter);

    }

    static void BT5()
    {
        Console.WriteLine("what conversion do you want to make: ");
        Console.Write("[1] celsius => fahrenheit --- ");
        Console.WriteLine("[2] fahrenheit => celsius");
        Console.Write("YOUR CHOICE: ");
        int yourchoice = int.Parse(Console.ReadLine());

        if (yourchoice == 1)
        {
            Console.Write("enter your celsius value: ");
            float celsius = float.Parse(Console.ReadLine());
            float conversion1 = celsius * 33.8f;
            Console.WriteLine("your fahrenheit value is {0}", conversion1);

        }
        else if (yourchoice == 2)
        {
            Console.Write("enter your fahrenheit value: ");
            float fahrenheit = float.Parse(Console.ReadLine());
            float conversion2 = fahrenheit / 33.8f;
            Console.WriteLine("your celsius value is {0}", conversion2);
        }
        else
        {
            Console.WriteLine("UNIDENTIED NUMBER");
        }
    }

    static void BT6()
    {
        Console.WriteLine("Size of byte = " + sizeof(byte) + " byte");
        Console.WriteLine("Size of sbyte = " + sizeof(sbyte) + " byte");
        Console.WriteLine("Size of ushort = " + sizeof(ushort) + " bytes");
        Console.WriteLine("Size of short = " + sizeof(short) + " bytes");
        Console.WriteLine("Size of uint = " + sizeof(uint) + " bytes");
        Console.WriteLine("Size of int = " + sizeof(int) + " bytes");
        Console.WriteLine("Size of ulong = " + sizeof(ulong) + " bytes");
        Console.WriteLine("Size of long = " + sizeof(long) + " bytes");
        Console.WriteLine("Size of float = " + sizeof(float) + " bytes");
        Console.WriteLine("Size of double = " + sizeof(double) + " bytes");
        Console.WriteLine("Size of decimal = " + sizeof(decimal) + " bytes");
        Console.WriteLine("Size of char = " + sizeof(char) + " bytes");
        Console.WriteLine("Size of bool = " + sizeof(bool) + " byte");
    }

    static void BT7()
    {
        Console.Write("enter your character: ");
        char Character = char.Parse(Console.ReadLine());
        int number = (int)Character;
        Console.WriteLine("your converted number is: {0}", number);
    }

    static void BT8()
    {
        Console.Write("enter your circle's radius: ");
        double radius = float.Parse(Console.ReadLine());
        double pi = 3.14;
        double square = (pi * Math.Sqrt(radius));
        Console.WriteLine("your area of your circle is: {0}", square);
    }

    static void BT8_2()
    {
        Console.Write("enter your circle's radius: ");
        float radius = float.Parse(Console.ReadLine());
        float pi = 3.14f;
        float square = pi * radius * radius;
        Console.WriteLine("your area of your circle is: {0}", square);
    }

    static void BT9()
    {
        Console.Write("enter your square's side: ");
        float side = float.Parse(Console.ReadLine());
        float square = side * side;
        Console.WriteLine($"your area of your square is: {square}");
    }

    static void BT10()
    {
        Console.Write("enter your numbers of days: ");
        int daysrandom = int.Parse(Console.ReadLine());
        int years = daysrandom / 365;
        int weeks = (daysrandom % 365) / 7;
        int days = (daysrandom % 365) % 7;
        Console.WriteLine($"{daysrandom} equals: {years} years, {weeks} weeks, {days} days");
    }

}
