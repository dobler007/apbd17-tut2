// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine("Mod 1");

static double GetAverage(int[] nums)
{
    double sum = 0.0;
    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
    }

    return sum / nums.Length;
}

int[] arr ={1,2,4,5,6,7,8,9};
Console.WriteLine(GetAverage(arr));