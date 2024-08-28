using System.Diagnostics.Contracts;

namespace AmeisenSimulation;

public class MovementController
{
    public void Spawn(Position position, String symbol)
    {
        Remove(position);
        Console.SetCursorPosition(position.X, position.Y);
        Console.Write(symbol);
    }

    public void Remove(Position position)
    {
        Console.SetCursorPosition(position.X, position.Y);
        Console.Write("\b \b");
        Console.Write(" ");
    }

    public void WalkAround()
    {
    }

    private Position GoRight(Position currenPosition)
    {
        ArgumentNullException.ThrowIfNull(currenPosition);

        Remove(currenPosition);
        currenPosition.X++;
        Spawn(currenPosition, ".");
        Thread.Sleep(3000);
        return currenPosition;
    }
    
    private Position GoLeft(Position currenPosition)
    {
        ArgumentNullException.ThrowIfNull(currenPosition);
        
        Remove(currenPosition);
        currenPosition.X--;
        Spawn(currenPosition, ".");
        Thread.Sleep(3000);
        return currenPosition;
    }


    public void GoTo(Position currentPosition, Position targetPosition, String symbol)
    {
        ArgumentNullException.ThrowIfNull(currentPosition);
        ArgumentNullException.ThrowIfNull(targetPosition);
        if (string.IsNullOrEmpty(symbol)) throw new ArgumentException("Symbol can not be null or empty");
        
        // Move right or left based on the target position
        while (currentPosition != targetPosition)
        {
            if (currentPosition.X < targetPosition.X)
            {
                currentPosition = GoRight(currentPosition);
            }
            else
            {
                currentPosition = GoLeft(currentPosition);
            }
        }
    }
}