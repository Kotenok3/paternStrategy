namespace paternStrategy;

public class MergeSort : StrategySort
{
    public int[] Sort(int[] array)
    {
        return Sort(array, 0, array.Length - 1);
    }
    
    //метод для слияния массивов
    static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
    {
        var left = lowIndex;
        var right = middleIndex + 1;
        var tempArray = new int[highIndex - lowIndex + 1];
        var index = 0;

        while ((left <= middleIndex) && (right <= highIndex))
        {
            if (array[left] < array[right])
            {
                tempArray[index] = array[left];
                left++;
            }
            else
            {
                tempArray[index] = array[right];
                right++;
            }

            index++;
        }

        for (var i = left; i <= middleIndex; i++)
        {
            tempArray[index] = array[i];
            index++;
        }

        for (var i = right; i <= highIndex; i++)
        {
            tempArray[index] = array[i];
            index++;
        }

        for (var i = 0; i < tempArray.Length; i++)
        {
            array[lowIndex + i] = tempArray[i];
        }
    }

    //сортировка слиянием
    static int[] Sort(int[] array, int lowIndex, int highIndex)
    {
        if (lowIndex < highIndex)
        {
            var middleIndex = (lowIndex + highIndex) / 2;
            Sort(array, lowIndex, middleIndex);
            Sort(array, middleIndex + 1, highIndex);
            Merge(array, lowIndex, middleIndex, highIndex);
        }

        return array;
    }
}