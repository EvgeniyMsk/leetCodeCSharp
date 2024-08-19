namespace LeetCodeCSharp.task2469;

public class TestApp
{
    private Solution Solution = new Solution();

    [Test]
    public void Test1()
    {
        double[] expectedArray = { 309.65000, 97.70000 };
        Assert.AreEqual(expectedArray, this.Solution.ConvertTemperature(36.50));
    }
    
    [Test]
    public void Test2()
    {
        double[] expectedArray = { 395.26000,251.79800 };
        Assert.AreEqual(expectedArray, this.Solution.ConvertTemperature(122.11));
    }
}