namespace TestProject1;

public class Tests
{
    private WebDriver driver = new ChromeDriver();
    
    [SetUp]
    public void Setup()
    {
        driver.Navigate().GoToUrl("http://www.google.com");
    }

    [Test]
    public void Test1()
    {
        for (int i = 0; i < 10; i++)
        {
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("Hello, Selenium WebDriver!" + i);
            query.Submit();
            Console.WriteLine(driver.Title);
        }
        driver.Close();
    }
}