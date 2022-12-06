using System.Runtime.InteropServices;
using LogicsService;

namespace LogicsServiceTest;

public class ShowServiceTest
{
    private readonly ShowService _showService;

    public ShowServiceTest(ShowService showService)
    {
        _showService = showService;
    }

    public void MyMethod(string parameter)
    {
        if(16 == _showService.Show().Count())
            Console.WriteLine($"uzunligi True");
        else    
            Console.WriteLine($"uzunligi False"); 
    }
}