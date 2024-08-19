namespace LeetCodeCSharp;

public class TestApp
{
    private Solution Solution = new Solution();
    
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Test1()
    {
        int[] nums = { 1,2,3,4 };
        Assert.AreEqual(3, Solution.MinimumOperations(nums));
    }
    
    [Test]
    public void Test2()
    {
        int[] nums = { 3, 6, 9 };
        Assert.AreEqual(0, Solution.MinimumOperations(nums));
    }
}