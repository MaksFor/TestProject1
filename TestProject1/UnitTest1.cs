namespace TestProject1;

public class Tests
{
    private readonly WebDriver _driver = new ChromeDriver();
    
    [SetUp]
    public void Setup()
    {
        _driver.Navigate().GoToUrl("https://www.google.com");
    }

    [Test]
    public void Test1()
    {
        for (int i = 0; i < 5; i++)
        {
            IWebElement query = _driver.FindElement(By.Name("q"));
            query.SendKeys("Hello, Selenium WebDriver!" + i);
            query.Submit();
            Console.WriteLine(_driver.Title);
        }
        _driver.Close();
    }
}