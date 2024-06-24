namespace ArmeisenSimulation;

public abstract class Programm
{
    public static void Main(String[] args)
    {
        var simulation = new Simulation();
        var ant = new Ant();
        var food = new Food();
        ant.GoHome();
    }
}

class Simulation
{
    public void IsFood(Position position)
    {

    }
}