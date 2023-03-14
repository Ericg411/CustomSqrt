namespace CustomSqrt.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int x = 4;
        int result = _test.MySqrt(x);
        Assert.AreEqual(2, result);
    } 
    
    [TestMethod]
    public void TestMethod2()
    {
        int x = 8;
        int result = _test.MySqrt(x);
        Assert.AreEqual(2, result);
    } 
    
    [TestMethod]
    public void TestMethod3()
    {
        int x = 45;
        int result = _test.MySqrt(x);
        Assert.AreEqual(6, result);
    }
}