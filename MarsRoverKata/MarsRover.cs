namespace MarsRoverKata;

public class MarsRover
{
    private readonly int x;
    private readonly int y;

    public MarsRover(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public string GetPosition()
    {
        return $"{x},{y}";
    }
}