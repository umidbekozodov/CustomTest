using LogicsService;
using Umid.TestRunner;

namespace LogicsServiceTest;

[TestClass]
public class LogicServiceTest
{
    private readonly LogicService _logicService;

    public LogicServiceTest()
    {
        _logicService = new LogicService();
    }

    [TestMethod]
    [TestMethodParameters(1, 2, 3)]
    public void SumTest(int a, int b, int s)
    {
        if(s == _logicService.Sum(a, b))
            Console.WriteLine($"True");
        else 
            Console.WriteLine($"False");
            
    }

    [TestMethod]
    public void MinusTest()
    {
        if (2 == _logicService.Minus(3, 1))
            Console.WriteLine(" togri");
        else
            Console.WriteLine(" notogri");


        if (2 == _logicService.Minus(5, 3))
            Console.WriteLine(" togri");
        else
            Console.WriteLine(" notogri");
    }
}