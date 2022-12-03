namespace RockPaperScissors.Domain;

internal class MySymbolConvertStrategy : SymbolConvertStrategy
{
    public override HandShape Convert(char symbol)
    {
        return symbol switch
        {
            'X' => HandShape.Rock,
            'Y' => HandShape.Paper,
            'Z' => HandShape.Scissors,
            _ => throw new Exception("Unsupported shape")
        };
    }
}