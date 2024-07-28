
using CSharpBasicApp;

class MainClass
{
    public static void Main(string[] args)
    {

        DaysOfWeek MyFavoriteDay;

        MyFavoriteDay = DaysOfWeek.Friday;

        Console.WriteLine(MyFavoriteDay);

        Console.WriteLine(Semaphore.Green);

        Console.ReadKey();

        IfElse.ChoiseColor();
    }
}

enum DaysOfWeek : byte
{
    Tuesday,
    Monday,
    Wednesday,
    Friday
}

enum Semaphore : int
{
    Red = 100,
    Yellow = 200,
    Green = 300,
}

class Singleton { 
    static Singleton() { 

    }
}