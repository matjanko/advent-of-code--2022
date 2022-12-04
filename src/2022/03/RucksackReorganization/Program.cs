using RucksackReorganization.Domain;

var inputs = File.ReadAllLines("../../../Input.txt");
var itemsList = inputs.Select(input => input.Select(x => x));
var rucksacks = itemsList.Select(items => new Rucksack(items.ToList()));

var shareItems = rucksacks.Select(x => x.GetShareItem());

var prioritySpecification = new PrioritySpecification();
var priority = shareItems.Select(x => prioritySpecification.GetPriority(x)).ToList();
var result = priority.Sum();

Console.WriteLine("--- Part One ---");
Console.WriteLine(result);

var rucksacksGroups = new List<RucksacksGroup>();
var rucksackGroup = new RucksacksGroup();
var counter = 1;
foreach (var rucksack in rucksacks.ToList())
{
    if (counter == 3)
    {
        rucksackGroup.AddRucksack(rucksack);
        rucksacksGroups.Add(rucksackGroup);
        rucksackGroup = new RucksacksGroup();
        counter = 1;
        continue;
    }
    rucksackGroup.AddRucksack(rucksack);
    counter++;
}

shareItems = rucksacksGroups.Select(x => x.GetShareItem()).ToList();
priority = shareItems.Select(x => prioritySpecification.GetPriority(x)).ToList();
result = priority.Sum();

Console.WriteLine("--- Part One ---");
Console.WriteLine(result);