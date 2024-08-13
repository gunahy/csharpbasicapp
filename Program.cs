
using CSharpBasicApp;

class MainClass
{
    public static void Main(string[] args)
    {

        //daysofweek myfavoriteday;

        //myfavoriteday = daysofweek.friday;

        //console.writeline(myfavoriteday);

        //console.writeline(semaphore.green);

        //console.readkey();

        //ifelse.choisecolor();

        //Cicles.Exsamle();

        //Arrays.ChangeCharInName();

        //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
        //Console.WriteLine(array.Length);
        //foreach (int i in array) Console.WriteLine(i);

        //Arrays.ArraySort();
        //Arrays.ArrWeight();

        //Console.WriteLine("Напишите что-то");
        //var str = Console.ReadLine();

        //Console.WriteLine("Укажите глубину эха");
        //var deep = int.Parse(Console.ReadLine());

        //Recurse.Echo(str, deep);

        //Console.WriteLine(Recurse.Factorial(20));

        //Console.WriteLine(Recurse.PowerUp(2, 3));
        //Console.ReadKey();

        Exercise56.Run();
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