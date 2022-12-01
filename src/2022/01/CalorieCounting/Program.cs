using CalorieCounting;

var calories = File.ReadAllLines("../../../Input.txt");

var elves = new List<Elf>();
var elf = new Elf();

foreach (var calorie in calories)
{
    if (string.IsNullOrEmpty(calorie))
    {
        elves.Add(elf);
        elf = new Elf();
        continue;
    }
    
    elf.AddCalories(int.Parse(calorie));
}

var total = elves.Max(x => x.GetTotalCalories());

Console.WriteLine("--- Part One ---");
Console.WriteLine(total);


var topElves = elves.OrderByDescending(x => x.GetTotalCalories()).Take(3);
total = topElves.Sum(x => x.GetTotalCalories());

Console.WriteLine("--- Part Two ---");
Console.WriteLine(total);