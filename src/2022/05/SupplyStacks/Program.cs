using SupplyStacks;

var inputs = File.ReadAllLines("../../../Input.txt").ToList();
var reader = new InputReader(inputs);

var stacks = reader.ReadStacks().ToList();
var moves = reader.ReadCraneMoves().ToList();

var ship = new Ship(stacks);

foreach (var move in moves)
{
    ship.MoveCratesBetweenStacks(move, true);
}

var message = string.Concat(ship.GetTopCrates().ToList());

Console.WriteLine("--- Part One ---");
Console.WriteLine(message);

stacks = reader.ReadStacks().ToList();
ship = new Ship(stacks);

foreach (var move in moves)
{
    ship.MoveCratesBetweenStacks(move, false);
}

message = string.Concat(ship.GetTopCrates().ToList());

Console.WriteLine("--- Part Two ---");
Console.WriteLine(message);
