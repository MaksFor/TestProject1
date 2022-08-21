namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        WebDriver driver = new ChromeDriver();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}