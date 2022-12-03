namespace RockPaperScissors.Domain;

internal class HandShapeConverter
{
    private readonly SymbolConvertStrategy _strategy;

    public HandShapeConverter(SymbolConvertStrategy strategy)
    {
        _strategy = strategy;
    }
    
    public HandShape Convert(char symbol)
    {
        return _strategy.Convert(symbol);
    }
}