using LogicsService;

namespace LogicsServiceTest;

public class CalculatorServiceTest
{
    private readonly CalculatorService _calculatorService;

    public CalculatorServiceTest(CalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
    }

    public void CalculateTest()
    {
        var result = _calculatorService.Calculate(4, 5, EOperation.Plus);

        if(result == 9)
            Console.WriteLine($"True");
        else
            Console.WriteLine($"False");
    }
}