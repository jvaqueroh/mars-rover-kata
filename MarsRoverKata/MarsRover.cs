namespace MarsRoverKata;

public class MarsRover
{
    private readonly int x;
    private readonly int y;

    public MarsRover(int x, int y, string s)
    {
        this.x = x;
        this.y = y;
    }

    public string GetPosition()
    {
        return $"{x},{y}";
    }

    public string GetDirection()
    {
        return string.Empty;
    }
}