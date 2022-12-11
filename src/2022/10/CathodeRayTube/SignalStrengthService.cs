namespace CathodeRayTube;

public class SignalStrengthService
{
    public int GetSignalStrength(int cycle, Processor processor)
    {
        return cycle switch
        {
            20 => 20 * processor.Register,
            60 => 60 * processor.Register,
            100 => 100 * processor.Register,
            140 => 140 * processor.Register,
            180 => 180 * processor.Register,
            219 => 220 * processor.Register,
            _ => 0
        };
    }
}