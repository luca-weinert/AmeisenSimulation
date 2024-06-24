namespace ArmeisenSimulation;

public class Ant : Object
{
    private Home _home;

    public Ant()
    {
        _home = new Home();
        Console.SetCursorPosition(Position.x, Position.y);
        Console.WriteLine(".");
    }

    public void MoveUp()
    {
        Position.y++;
        Console.SetCursorPosition(Position.x, Position.y);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.Clear();
    }

    public void MoveDown()
    {

        Position.y--;
        Console.SetCursorPosition(Position.x, Position.y);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.Clear();
    }

    public void MoveLeft()
    {
        Position.x--;
        Console.SetCursorPosition(Position.x, Position.y);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.Clear();
    }

    public void MoveRight()
    {
        Position.x++;
        Console.SetCursorPosition(Position.x, Position.y);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.Clear();
    }

    public void GoHome()
    {
        int x = _home.Position.x - Position.x;
        int y = _home.Position.y - Position.y;
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}