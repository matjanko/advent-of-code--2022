namespace RockPaperScissors.Domain;

internal abstract class SymbolConvertStrategy
{
    public abstract HandShape Convert(char symbol);
}