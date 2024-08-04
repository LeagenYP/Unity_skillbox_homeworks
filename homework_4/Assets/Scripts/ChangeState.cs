using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeState : MonoBehaviour
{

    [SerializeField] private GameObject calculatorScreen;
    [SerializeField] private GameObject compareScreen;

    private GameObject currentScreen;

    void Start()
    {
        calculatorScreen.SetActive(true);
        currentScreen = calculatorScreen;
    }

    public void DoChangeState(GameObject state)
    {
        if (currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
    }
}
