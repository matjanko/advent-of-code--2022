using SupplyStacks;

var inputs = File.ReadAllLines("../../../Input.txt").ToList();
var converter = new InputReader(inputs);

var stacks = converter.ReadStacks();
var moves = converter.ReadCraneMoves();

Console.WriteLine("--- Part One ---");