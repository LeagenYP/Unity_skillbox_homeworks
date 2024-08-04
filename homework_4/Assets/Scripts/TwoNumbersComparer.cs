using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private InputField firstNumber;
    [SerializeField] private InputField secondNumber;
    [SerializeField] private Text result;

    public void compareNumbers()
    {
        if (firstNumber.text != "" && secondNumber.text != "")
        {
            if ((Int32.Parse(firstNumber.text)) > (Int32.Parse(secondNumber.text))) {
                result.text = firstNumber.text;
            }
            else if ((Int32.Parse(firstNumber.text)) < (Int32.Parse(secondNumber.text)))
            {
                result.text = secondNumber.text;
            }
            else
            {
                result.text = "Числа равны";
            }

        }
    }
}
