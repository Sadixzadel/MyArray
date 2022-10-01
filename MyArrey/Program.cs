using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3;

class MyArray
{
    public int[] array;

    public MyArray(int size)
    {
        array = new int[size];

        var random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(0, 10);
        }
    }

    public void Sort(int size)
    {
        // Bubble sort algorithm here

        int temp;
        array = new int[size];


        for (int i = 0; i < size; i++)
        {
            if (array[0] > array[i])
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;
            }

        }
    }

    public void Reverse(int size)
    {
        // Reverse array algorithm here

        array = new int[size];


        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = temp;
        }
    }

    public override string ToString()
    {
        // Output using StringBuilder
        var builder = new StringBuilder();
        int size = 11;

        array = new int[size];

        var random = new Random();

        for (int i = 0; i < size; i++)
        {
            builder.Append($"{array[i]} ");
        }
        builder.Append('\n');

        return builder.ToString();


    }

}