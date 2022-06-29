// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/***for (int i = 1; i <= 100; i++){
    if (i % 15 == 0){
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0){
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0){
        Console.WriteLine("Buzz");
    }
    else{
        Console.WriteLine(i);
    }
}***/
/***
int max = 500; 
for (byte i = 0; i < max; i++) {
    Console.WriteLine(i); 
}***/
//infinity loop

/***for (int i = 1; i<=5; i++){
    for (int j = 1; j<=5-i; j++){
        Console.Write(" ");
    }
    for (int s = 1; s<= 2*i-1; s++){
        Console.Write("*");
    }
    Console.Write("\n");
}***/

//3.
/***Random ran = new Random();
int target = ran.Next(0, 4);


while (true)
{
    Console.WriteLine("Guess a number between 1 and 3");
    int guess = Convert.ToInt32(Console.ReadLine());
    if (guess >= 1 and guess <= 3)
    {
        if (guess == target){
            Console.WriteLine("Correct");
            break;
        }
        else if (guess < target)
            Console.WriteLine("Too low");
        else
            Console.WriteLine("Too high");

    }
    else
    {
        Console.WriteLine("Out of range");
    }
}***/

/***DateTime Cur = DateTime.Today;

Console.WriteLine("Enter the month: ");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the day: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the year: ");
int year = Convert.ToInt32(Console.ReadLine());

DateTime Born = new DateTime(year, month, day);

TimeSpan diff = Cur.Subtract(Born);
Console.WriteLine(diff);***/

/***
DateTime Current = DateTime.Now;
int curr = Current.Hour;
int Morning = 5;
int Afternoon = 12;
int Evening = 18;
int Night = 22;

if (curr >= Morning  && curr < Afternoon)
{
    Console.WriteLine("Good Morning");
}
else if (curr >= Afternoon && curr < Evening)
{
    Console.WriteLine("Good Afternoon!");
}
else if (curr >= Evening && curr < Night)
{
    Console.WriteLine("Good Evening!");
}
else 
{
    Console.WriteLine("Good Night!");
}
***/

for (int i = 1; i <= 4; i += 1)
{
    for (int j = 0; j <= 24; j += i)
    {
        if ( j < 24)
         Console.Write($"{j},");
        else
            Console.Write($"{j}");
    }

    Console.WriteLine();
}