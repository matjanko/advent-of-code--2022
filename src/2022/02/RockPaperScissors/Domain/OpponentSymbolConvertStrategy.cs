namespace RockPaperScissors.Domain;

internal class OpponentSymbolConvertStrategy : SymbolConvertStrategy
{
    public override HandShape Convert(char symbol)
    {
        return symbol switch
        {
            'A' => HandShape.Rock,
            'B' => HandShape.Paper,
            'C' => HandShape.Scissors,
            _ => throw new Exception("Unsupported symbol")
        };
    }
}