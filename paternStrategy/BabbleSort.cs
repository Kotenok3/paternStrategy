namespace paternStrategy;

public class BabbleSort : StrategySort
{
    public int[] Sort(int[] array)
    {
        var len = array.Length;
        for (var i = 1; i < len; i++)
        {
            for (var j = 0; j < len - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }

        return array;
    }
}