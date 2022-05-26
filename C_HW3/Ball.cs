using System;
using C_HW3;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Ball
{
    public int Size { get; set; }
    public Color Color { get; set; }
    public int Throw { get; set; }

    public Ball(int size, Color color, int t = 0)
    {
        Size = size;
        Color = color;
        Throw = t;
    }

    public void Pop()
    {
        Size = 0;

    }
    public void Throwing()
    {
        if (Size != 0)
        {
            Throw += 1;
        }
        else
        {
            Console.WriteLine("Failed.");
        }
    }
    public int GetThrow()
    {
        return Throw;
    }
}
