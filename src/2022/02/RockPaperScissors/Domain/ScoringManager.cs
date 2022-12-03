namespace RockPaperScissors.Domain;

internal class ScoringManager
{
    public int ScoreForShape(HandShape shape)
    {
        return shape switch
        {
            HandShape.Rock => 1,
            HandShape.Paper => 2,
            HandShape.Scissors => 3,
            _ => throw new Exception("Unsupported hand shape")
        };
    }

    public int ScoreForWinner() => 6;
    public int ScoreForDraw() => 3;
}