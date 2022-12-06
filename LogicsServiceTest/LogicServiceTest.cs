using LogicsService;

namespace LogicsServiceTest;

public class LogicServiceTest
{
    private readonly LogicService _logicService;

    public LogicServiceTest(LogicService logicService)
    {
        _logicService = logicService;
    }
    public void SumTest(int a, int b, int s)
    {
        if(s == _logicService.Sum(a, b))
            Console.WriteLine($"True");
        else 
            Console.WriteLine($"False");
            
    }
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