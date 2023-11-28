using System.Security.Cryptography.X509Certificates;

namespace paternStrategy;

public class SortedArray
{
    private StrategySort _strategy;

    public SortedArray(StrategySort strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(StrategySort strategy)
    {
        _strategy = strategy;
    }

    public int[] Sort(int[] array)
    {
        return _strategy.Sort(array);
    }
}