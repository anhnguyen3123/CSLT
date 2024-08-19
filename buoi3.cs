internal class buoi3
{
    private static void Main(string[] args)
    {
        //EX1();
        //EX2();
        //EX3();
        //int c =  cong(6, 7);
        //Console.WriteLine(c);
        //int a = 5;
        //String s = a + " ";
        //Console.WriteLine(s);
    }
    static void EX1()
    {
        Console.Write("enter celsius here:");

        float celsius = Convert.ToSingle(Console.ReadLine());

        float kelvin = celsius + 273;

        float fahrenheit = celsius * 18 / 10 + 32;

        Console.WriteLine("kevin:" + kelvin);
        Console.WriteLine("fahrenheit:" + fahrenheit);
    }

    static void EX2()
    {
        Console.Write("enter radius here:");

        float radius = Convert.ToSingle(Console.ReadLine());

        double surface = 4 * Math.PI * Math.Pow(radius, 2);

        double volume = 4/3 * Math.PI * Math.Pow(radius,3);

        Console.WriteLine("surface:" + surface);
        Console.WriteLine("volumn:" + volume);

    }

    static void EX3()
    {
        Console.Write("enter num1 here:");
        float num1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("enter num2 here:");
        float num2 = Convert.ToSingle(Console.ReadLine());

        float sum = num1 + num2;
        float sub = num1 - num2;
        float mul = num2 * num1;
        float dev = num1 / num2;
        float mod = num1 % num2;

        Console.WriteLine("sum: " + sum);
        Console.WriteLine("sub: " + sub);
        Console.WriteLine("mul: " + mul);
        Console.WriteLine("dev: " + dev);
        Console.WriteLine("mod: " + mod);
    }

    static int cong(int a, int b)
    {
        return a + b;
    }


}

