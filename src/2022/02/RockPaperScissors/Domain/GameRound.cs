namespace RockPaperScissors.Domain;

public class GameRound
{
    private readonly ScoringManager _scoringManager;
    private readonly Player _playerA;
    private readonly Player _playerB;
    
    public GameRound(Player playerA, Player playerB)
    {
        _scoringManager = new ScoringManager();
        _playerA = playerA;
        _playerB = playerB;
    }

    public void Move(HandShape shapeA, HandShape shapeB)
    {
        PointsForShape(shapeA, shapeB);

        if ((shapeA == HandShape.Paper && shapeB == HandShape.Rock) || 
            (shapeA == HandShape.Rock && shapeB == HandShape.Scissors) || 
            (shapeA == HandShape.Scissors && shapeB == HandShape.Paper))
        {
            PointsForWinner(_playerA);
        } 
        else if ((shapeA == HandShape.Rock && shapeB == HandShape.Paper) ||
                 (shapeA == HandShape.Scissors && shapeB == HandShape.Rock) ||
                 (shapeA == HandShape.Paper && shapeB == HandShape.Scissors))
        {
            PointsForWinner(_playerB);
        }
        else if ((shapeA == shapeB))
        {
            PointsForDraw();
        }
    }

    private void PointsForShape(HandShape shapeA, HandShape shapeB)
    {
        _playerA.AddPoints(_scoringManager.ScoreForShape(shapeA));
        _playerB.AddPoints(_scoringManager.ScoreForShape(shapeB));
    }
    private void PointsForWinner(Player player)
    {
        player.AddPoints(_scoringManager.ScoreForWinner());
    }

    private void PointsForDraw()
    {
        _playerA.AddPoints(_scoringManager.ScoreForDraw());
        _playerB.AddPoints(_scoringManager.ScoreForDraw());
    }
}