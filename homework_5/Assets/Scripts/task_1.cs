using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_1 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(FindSum());
    }

    private int FindSum()
    {
        int result = 0;

        for (int i = 7; i < 22; i++)
        {
            if (i % 2 == 0)
            {
                result += i;
            }
        }
        return result;
    }
}
