using LogicsService;
using Umid.TestRunner;

namespace LogicsServiceTest;

[TestClass]
public class CalculatorServiceTest
{
    private readonly CalculatorService _calculatorService;

    public CalculatorServiceTest()
    {
        _calculatorService = new CalculatorService();
    }

    [TestMethod]
    public void CalculateTest()
    {
        var result = _calculatorService.Calculate(4, 5, EOperation.Plus);

        if(result == 9)
            Console.WriteLine($"True");
        else
            Console.WriteLine($"False");
    }
}