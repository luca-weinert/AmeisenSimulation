namespace AmeisenSimulation;

public abstract class Programm
{
    public static void Main(String[] args)
    {
        Console.Clear();
        Console.WindowHeight = 10;
        Console.WindowWidth = 10;
        Console.ForegroundColor = ConsoleColor.Blue;
        var ant = new Ant();
        // var food = new Food();
        ant.GoHome();
    }
}