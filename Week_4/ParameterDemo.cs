public class ParameterDemo
{
    // 1. Method using ref to increase the number by 10
    public void Increase(ref int number)
    {
        number += 10;
    }

    // 2. Method using out to assign full name
    public void GetFullName(out string fullName)
    {
        fullName = "Ashish Limbu"; // replace with your full name
    }

    // 3. Method using params to sum all numbers
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
