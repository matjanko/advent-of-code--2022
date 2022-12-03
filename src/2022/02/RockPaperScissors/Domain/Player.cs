namespace RockPaperScissors.Domain;

public class Player
{
    public int Points { get; private set; }

    public void AddPoints(int points)
    {
        Points += points;
    }

    public void ResetPoints()
    {
        Points = 0;
    }
}