using System.Runtime.InteropServices;
using LogicsService;
using Umid.TestRunner;

namespace LogicsServiceTest;

[TestClass]
public class ShowServiceTest
{
    private readonly ShowService _showService;

    public ShowServiceTest()
    {
        _showService = new ShowService();
    }

    [TestMethod]
    public void MyMethod()
    {
        if(16 == _showService.Show().Count())
            Console.WriteLine($"uzunligi True");
        else    
            Console.WriteLine($"uzunligi False"); 
    }
}