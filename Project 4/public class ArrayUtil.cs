public class ArrayUtil
{
    int[] intArray;
    public ArrayUtil() // constructor no args
    {

    }
    public ArrayUtil(int[] array)
    {
        intArray = array; // constructor with args
    }

    public int[] getarray()
    {
        return intArray;
    }
    public void setarray(int[] array)
    {
        intArray = array;
    }

    public int minimum()
    {
        if (intArray.length == 0) // checks for empty array
            return 0;
        int smallest = intArray[0];
        for (int number : intArray)
        {
            if (number < smallest) // finds the smallest number
            {
                smallest = number;
            }
        }
        return smallest;
    }
// Bonus: Swap Method
    public int[] swap(int ind1, int ind2)
    {
        System.out.println(intArray[ind1] + " " + intArray[ind2]);
        int holder = intArray[ind1];
        intArray[ind1] = intArray[ind2];
        intArray[ind2] = holder;
        System.out.println(intArray[ind1] + " " + intArray[ind2]);
        return intArray;
    }

    public int maximum()
    {
        if (intArray.length == 0) // checks for empty array
            return 0;
        int largest = intArray[0];
        for (int number : intArray)
        {
            if (number > largest) // finds the largest number
            {
                largest = number;
            }
        }
        return largest;
    }

    public int unique()
    {
        if (intArray.length == 0) // checks for empty array
            return 0;
        String pos = ""; // creates the three strings to store unique values
        String neg = "";
        String great = "";
        int unique = 0;
        for (int number : intArray)
        {
            if (number < 0) // Checks if the negative number is unique
            {
                if (neg.indexOf(Integer.toString(number)) == -1)
                {
                    unique++;
                    neg = neg + Integer.toString(number) + " ";
                }
            }
            else if (number > 9) // Checks if the number greater than 9 is unique
            {
                if (great.indexOf(Integer.toString(number)) == -1)
                {
                    unique++;
                    great = great + Integer.toString(number) + " ";
                }
            }
            else // Checks if the positive number 9 or less is unique
            {
                if (pos.indexOf(Integer.toString(number)) == -1)
                {
                    unique++;
                    pos = pos + Integer.toString(number) + " ";
                }
            }
        }
        return unique;
    }
}