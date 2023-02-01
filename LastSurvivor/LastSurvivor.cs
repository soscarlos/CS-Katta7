namespace LastSurvivor;

public class LastSurvivor
{
    public string GetLastSurvivorNumber(string letters, int[] coordinates)
    {
        var length = coordinates.Length;
        var result = letters;
        for (var i = 0; i < length; i++)
        {
            result = result.Remove(coordinates[i], 1);
        }
        return result;
    }
}