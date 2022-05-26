using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public static class ReverseNumbers

{
    public static int[] Reverse(int[] array)
    {
        int i = 0;
        int j = array.Length - 1;
        int temp;
        while (i < j)
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
        return array;
    }
}
