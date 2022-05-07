using System;
Welcome:

Console.Write("Yashinizi qeyd edin: ");
int age = Convert.ToInt32(System.Console.ReadLine());

if (age > 18)
{
    Console.Write("Balinizi qeyd edin: ");
    int point = Convert.ToInt32(Console.ReadLine());
    if (point>50)
    {
        Console.WriteLine("Tebrikler");
    }
    else
    {
        goto Welcome;
    }
}
else {
    goto Welcome;
}