namespace LogicsService;

public class CalculatorService
{
    public int Calculate(int a, int b, EOperation operation)
    {
        return operation switch
        {
            EOperation.Plus => a + b,
            EOperation.Minus => a - b,
            _ => throw new ArgumentOutOfRangeException(nameof(operation), operation, null)
        };
    }
}

public enum EOperation
{
    Plus,
    Minus
}