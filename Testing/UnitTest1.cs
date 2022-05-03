using NUnit.Framework;
using TestableModule;

namespace Testing;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    
    [Test]
    public void Test2()
    {
        Assert.True(new Class1().Ok() == "ok");
    }
    
    [Test]
    public void Test3()
    {
        Assert.True(new Class1().Err() == "ok");
    }
}