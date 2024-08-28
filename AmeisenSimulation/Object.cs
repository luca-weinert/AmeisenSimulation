namespace AmeisenSimulation;

public class Object
{
    public Position Position { get; set; }
    private readonly Random _r = new Random();
    
    protected Object()
    {
        Position = new Position
        {
            X = _r.Next(1,10), 
            Y = _r.Next(1,10)
        };
    }
}