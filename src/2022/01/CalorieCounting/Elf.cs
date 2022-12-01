namespace CalorieCounting;

public class Elf
{
    private readonly List<int> _calories = new();

    public void AddCalories(int calories)
    {
        _calories.Add(calories);
    }

    public int GetTotalCalories() 
        => _calories.Sum();
}