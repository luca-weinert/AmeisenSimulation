namespace AmeisenSimulation;

public class Ant : Object
{
    private Home _home;
    private MovementController _movementController;
    
    public Ant()
    {
        _home = new Home();
        _movementController = new MovementController();
        _movementController.Spawn(Position, ".");
    }

    public void GoHome()
    {
        _movementController.GoTo(Position, _home.Position, ".");
    }

    public void WalkAround()
    {
        _movementController.WalkAround();
    }
}