using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class task_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = CreateArray(10);
        WriteArray(array);
        Debug.Log($"Sum = {FindSumArray(array)}");
    }

    private int[] CreateArray(int length)
    {
        int[] array = new int[length];
        Random rand = new Random();

        for (int i = 0; i < length; i++)
        {
            array[i] = rand.Next(20);
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

    private int FindSumArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {

            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }
        return sum;

    }
}
