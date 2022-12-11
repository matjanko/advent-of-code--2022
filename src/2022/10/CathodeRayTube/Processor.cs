namespace CathodeRayTube;

public class Processor
{
    public int Register { get; private set; }

    public Processor()
    {
        Register = 1;
    }

    public void IncreaseRegister(int value)
    {
        Register = Register + value;
    }
}