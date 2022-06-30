/***
1.long
2.float or double
3.int
4.string
5.decimal
6.string
7.float or double or decimal
8.float
9.decimal
10.ulong
11.ulong
Boxing is used to store value types in the garbage-collected heap.
Unboxing is an explicit conversion from the type object to a value type or from an interface type to a value type that implements the interface.
3.What is meant by the terms managed resource and unmanaged resource in .NET
Managed resources are those that are pure . NET code and managed by the runtime and are under its direct control. Unmanaged resources are those that are not.

4.Whats the purpose of Garbage Collector in .NET? 
The garbage collector manages the allocation and release of memory for an application. For developers working with managed code, this means that you don't have to write code to perform memory management tasks.

1.Complie error
2.Infinity
3. when an overflow occurs as a result of an arithmetic operation on an integer type
4.add after execution or first
5.break: jump out of the loop, continue: skip the rest code and execute next iteration, return: caller
6.initialization, condition, increment/decrement
7. =: assign value to variable, ==: compare two variable
8.no
9.The underscore (_) character replaces the default keyword to signify that it should match anything if reached.
10.IEunemerable Interface
***/

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

