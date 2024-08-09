using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;
using System.Linq;

public class task_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] myArray = CreateArray(10);
        WriteArray(myArray);

        SelectionSort(myArray);

        WriteArray(myArray);
    }

    private int[] CreateArray(int length)
    {
        int[] array = new int[length];
        Random rand = new Random();

        for (int i = 0; i < length; i++)
        {
            array[i] = rand.Next(-100, 101);
        }
        return array;
    }

    private void WriteArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log($"Element ¹{i + 1}: {array[i]}");
        }
    }

    private void SelectionSort(int[] array)
    {
        int min;
        for (int i = 0; i < array.Length; i++)
        {
            min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            int temp = array[min];
            array[min] = array[i];
            array[i] = temp;
        }
    }
}
