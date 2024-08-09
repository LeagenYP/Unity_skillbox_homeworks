using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class task_3 : MonoBehaviour
{
    void Start()
    {
        int[] array = CreateArray(10);
        WriteArray(array);

        int numberWeWantToFind = 5;

        Debug.Log($"First index of number {numberWeWantToFind} in array is {FindFirstIndex(numberWeWantToFind, array)}");
    }

    private int[] CreateArray(int length)
    {
        int[] array = new int[length];
        Random rand = new Random();

        for (int i = 0; i < length; i++)
        {
            array[i] = rand.Next(10);
        }
        return array;
    }

    private void WriteArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log($"Element with index {i}: {array[i]}");
        }
    }

    private int FindFirstIndex(int number, int[] array)
    {
        int index = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                index = i;
                break;
            }
        }
        return index;
    }
}

