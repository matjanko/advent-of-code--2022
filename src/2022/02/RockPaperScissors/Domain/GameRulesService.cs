namespace RockPaperScissors.Domain;

internal class GameRulesService
{
    public static HandShape GetWinnerShape(HandShape shape)
    {
        return shape switch
        {
            HandShape.Paper => HandShape.Scissors,
            HandShape.Rock => HandShape.Paper,
            HandShape.Scissors => HandShape.Rock,
            _ => throw new Exception("Unsupported hand shape")
        };
    }

    public static HandShape GetLostShape(HandShape shape)
    {
        return shape switch
        {
            HandShape.Paper => HandShape.Rock,
            HandShape.Rock => HandShape.Scissors,
            HandShape.Scissors => HandShape.Paper,
            _ => throw new Exception("Unsupported hand shape")
        };
    }
}