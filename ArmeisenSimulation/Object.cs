namespace ArmeisenSimulation;

public class Object
{
    public Position Position { get; }
    private readonly Random _r = new Random();
    
    protected Object()
    {
        Position = new Position
        {
            x = _r.Next(1,10), 
            y = _r.Next(1,10)
        };
    }
}