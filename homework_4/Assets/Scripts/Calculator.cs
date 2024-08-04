using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using Unity.VisualScripting.AssemblyQualifiedNameParser;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField firstNumber;
    [SerializeField] private InputField secondNumber;
    [SerializeField] private Text result;

    public void sumNumbers()
    {
        if (firstNumber.text != "" && secondNumber.text != "")
        {
            result.text = (Int32.Parse(firstNumber.text) + Int32.Parse(secondNumber.text)).ToString();
        }
    }

    public void minusNumbers()
    {
        if (firstNumber.text != "" && secondNumber.text != "")
        {
            result.text = (Int32.Parse(firstNumber.text) - Int32.Parse(secondNumber.text)).ToString();
        }
    }

    public void multiplyNumbers()
    {
        if (firstNumber.text != "" && secondNumber.text != "")
        {
            result.text = (Int32.Parse(firstNumber.text) * Int32.Parse(secondNumber.text)).ToString();
        }
    }

    public void divideNumbers()
    {
        if (firstNumber.text != "" && secondNumber.text != "")
        {
            result.text = (Double.Parse(firstNumber.text) / Double.Parse(secondNumber.text)).ToString("#.##");
        }
    }
}
