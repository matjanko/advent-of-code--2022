using RockPaperScissors.Domain;

var inputs = File.ReadAllLines("../../../Input.txt");

var playerA = new Player();
var playerB = new Player();

var game = new Game(playerA, playerB);

foreach (var input in inputs)
{
    var shapeA = new HandShapeConverter(new OpponentSymbolConvertStrategy()).Convert(input[0]);
    var shapeB = new HandShapeConverter(new MySymbolConvertStrategy()).Convert(input[2]);
    game.PlayRound(shapeA, shapeB);
}

var result = playerB.Points;

Console.WriteLine("--- Part One ---");
Console.WriteLine(result);

game.StartNewGame();

foreach (var input in inputs)
{
    var shapeA = new HandShapeConverter(new OpponentSymbolConvertStrategy()).Convert(input[0]);
    var shapeB = new HandShapeConverter(new MySymbolConvertStrategyDecorator(input)).Convert(input[2]);
    game.PlayRound(shapeA, shapeB);
}

result = playerB.Points;

Console.WriteLine("--- Part Two ---");
Console.WriteLine(result);

