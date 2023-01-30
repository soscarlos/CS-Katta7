namespace LastSurvivor;

public class Tests
{
    private readonly LastSurvivor _lastSurvivor = new LastSurvivor();
    [SetUp]
    public void Setup()
    {
        
    }
    [Test]
    public void Test1()
    {
        var result = _lastSurvivor.GetLastSurvivorNumber("abc", new[] { 0, 1 });
        
        Console.WriteLine(result);
        Assert.Pass();
    }
}