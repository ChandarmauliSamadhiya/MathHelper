﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class MathHelper
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("The array must contain elements.");

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        return (double)sum / numbers.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        double average = MathHelper.CalculateAverage(numbers);
        Console.WriteLine($"Average: {average}");
        Console.ReadLine();
    }
}

