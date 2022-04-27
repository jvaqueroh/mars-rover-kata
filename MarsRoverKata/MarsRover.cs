namespace MarsRoverKata;

public class MarsRover
{
    private readonly int x;
    private int y;
    private readonly string direction;

    public MarsRover(int x, int y, string direction)
    {
        this.x = x;
        this.y = y;
        this.direction = direction;
    }

    public string GetPosition()
    {
        return $"{x},{y}";
    }

    public string GetDirection()
    {
        return direction;
    }

    public string ExecuteCommand(string command)
    {
        if (command.StartsWith("f"))
        {
            y--;
            return GetPosition();
        }

        y++;
        return GetPosition();
    }
}