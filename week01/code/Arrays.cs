public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // We need to create a function that will return an array of multiples of the param="number." The param="length" will be the
        // number of multiples. Example: MultiplesOf(3, 5) => {3, 6, 9, 12, 15}. 3*1=3, 3*2=6, 3*3=9, 3*4=12, 3*5=15. The # of multiples is 5.
        // Let's start by declaring the starting values of each params.
        double startValue = number;
        int numMultiples = length;

        // Now, let's create an array to hold the multiples. Use the variable of numMultiples as the base length of the array.
        double[] multiples = new double[numMultiples];

        // Now, let's loop through the array and assign the multiples.
        // Create a for loop to iterate through the array. i must start from 0 and end at numMultiples.
        // update the array index to be the startValue * (i + 1).
        for (int i = 0; i < numMultiples; i++)
        {
            multiples[i] = startValue * (i + 1);
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // We need to create a function that will rotate the param="List<int> data" to the right by the param="int amount."
        // If the amount is to move "5" digits to the front, the last "5" digits will be moved to the front. Example:
        // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9} => <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}.
        // Let's start by declaring the list and the amount.
        List<int> list = data;

        // Now, let's identify the corresponding index
        int index = list.Count - amount;

        // Now, let's split the list in halves to identify where the index falls using the GetRange method
        List<int> firstHalf = list.GetRange(0, index);
        List<int> secondHalf = list.GetRange(index, list.Count - index);

        // Now, let's clear the list then merge both halves into one.
        list.Clear();
        list.AddRange(secondHalf);
        list.AddRange(firstHalf);

    }
}
