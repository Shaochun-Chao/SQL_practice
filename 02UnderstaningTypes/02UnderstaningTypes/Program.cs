// See https://aka.ms/new-console-template for more information
//sbyte, byte, short, ushort, int, uint, long,ulong, float, double, and decimal.
Console.WriteLine("sbyte Max: {0}, Min :{1}", sbyte.MaxValue, sbyte.MinValue);
Console.WriteLine("byte Max :{0}, Min :{1}", byte.MaxValue, byte.MinValue);
Console.WriteLine("short Max :{0}, Min :{1}", short.MaxValue, short.MinValue);
Console.WriteLine("ushort Max :{0}, Min :{1}", ushort.MaxValue, ushort.MinValue);
Console.WriteLine("int Max :{0}, Min :{1}", int.MaxValue, int.MinValue);
Console.WriteLine("uint Max :{0}, Min :{1}", uint.MaxValue, uint.MinValue);
Console.WriteLine("long Max :{0}, Min :{1}", long.MaxValue, long.MinValue);
Console.WriteLine("ulong Max :{0}, Min :{1}", ulong.MaxValue, ulong.MinValue);
Console.WriteLine("float Max :{0}, Min :{1}", float.MaxValue, float.MinValue);
Console.WriteLine("double Max :{0}, Min :{1}", double.MaxValue, double.MinValue);
Console.WriteLine("decimal Max :{0}, Min :{1}", decimal.MaxValue, decimal.MinValue);

while (true)
{
    int num;
    Console.WriteLine("Input");
    //Centruies

    num = Convert.ToInt16(Console.ReadLine());

    ushort Years = (ushort)(num * 100);

    float Days = (float)(Years * 365.24);

    float Hours = (float)(Days * 24);

    double Minutes = Hours * 60;

    double Seconds = Minutes * 60;

    decimal Milliseconds = (decimal)(Seconds * 1000);

    decimal Microseconds = (Milliseconds * 1000);

    decimal Nanoseconds = (Microseconds * 1000);

    Console.WriteLine($"{num} Centruies = {Years} Years = {Days} Days = {Hours} Hours = {Minutes} Minutes = {Seconds} Seconds = {Milliseconds} Milliseconds = {Microseconds} Microseconds = {Nanoseconds} Nanoseconds");
}

