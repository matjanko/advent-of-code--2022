namespace RockPaperScissors.Domain;

public class Game
{
    private readonly Player _playerA;
    private readonly Player _playerB;

    public Game(Player playerA, Player playerB)
    {
        _playerA = playerA;
        _playerB = playerB;
    }

    public void PlayRound(HandShape shapeA, HandShape shapeB)
    {
        var round = new GameRound(_playerA, _playerB);
        round.Move(shapeA, shapeB);
    }

    public void StartNewGame()
    {
        _playerA.ResetPoints();
        _playerB.ResetPoints();
    }
}