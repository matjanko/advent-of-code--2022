namespace TuningTrouble;

internal class MarkerDetector
{
    public int ProcessedCharsBeforeMarkerDetected(char[] chars, string buffer, int distinctCharsCounter)
    {
        for (var i = distinctCharsCounter - 1; i < chars.Length; i++)
        {
            var lastChars = buffer.Substring(i - (distinctCharsCounter - 1), distinctCharsCounter).ToCharArray();
            if (lastChars.Distinct().Count() == distinctCharsCounter)
            {
                return i + 1;
            }
        }

        return -1;
    }
}