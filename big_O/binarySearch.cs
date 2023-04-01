using System;

int[] arrOne = { 1, 2, 3, 4, 6, 7, 8, 9, 10, 33, 35, 38, 44, 55, 61, 62, 63, 64, 77, 88, 89, 90, 94, 100 };
int start = 0;
int end = arrOne.Length;
int target = 93;

static bool binarySearch(int[] arr, int start, int end, int target)
{
    if (start > end) return false;
    int midIndex = (start + end) / 2;
    if (arr[midIndex] == target)
    {
        Console.WriteLine("= target");
        return true;
    }

    if (arr[midIndex] > target)
    {
        Console.WriteLine($"arr[midIndex] {arr[midIndex]} Greater than");
        return binarySearch(arr, start, midIndex - 1, target);
    }
    else
    {
        Console.WriteLine($"arr[midIndex] {arr[midIndex]} Less than");
        return binarySearch(arr, midIndex + 1, end, target);
    }
}

bool result = binarySearch(arrOne, start, end, target);
Console.WriteLine($"result: {result}");