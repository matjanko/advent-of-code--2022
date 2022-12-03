namespace RockPaperScissors.Domain;

internal class MySymbolConvertStrategyDecorator: SymbolConvertStrategy
{
    private readonly HandShape _opponentShape;
    public MySymbolConvertStrategyDecorator(string input)
    {
        _opponentShape = new HandShapeConverter(new OpponentSymbolConvertStrategy()).Convert(input[0]);
    }
    
    public override HandShape Convert(char symbol)
    {
        var roundResult = GetRoundResult(symbol);
        return roundResult switch
        {
            RoundResult.Draw => _opponentShape,
            RoundResult.Win => GameRulesService.GetWinnerShape(_opponentShape),
            RoundResult.Lose => GameRulesService.GetLostShape(_opponentShape),
            _ => throw new Exception("Wrong round result")
        };
    }

    private RoundResult GetRoundResult(char symbol)
    {
        return symbol switch
        {
            'X' => RoundResult.Lose,
            'Y' => RoundResult.Draw,
            'Z' => RoundResult.Win,
            _ => throw new Exception("Unsupported symbol")
        };
    }
}