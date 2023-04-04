public class Numbers
{
    public int sumTwoSmallestNumbers(int[] numbers)
    {
        Array.Sort(numbers);
        return numbers[0] + numbers[1];
    }
}