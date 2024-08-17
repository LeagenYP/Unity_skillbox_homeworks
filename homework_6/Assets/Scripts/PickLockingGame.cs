using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
using Random = System.Random;

public class PickLockingGame : MonoBehaviour
{
    [SerializeField] private GameObject lockPickButton;
    [SerializeField] private GameObject screwdriverButton;
    [SerializeField] private GameObject clipButton;
    [SerializeField] private Text timerText;
    private float timeStart = 60f;
    public GameObject resultPanel;
    Random random = new Random();
    
    int pin_1;
    int pin_2;
    int pin_3;
    public Text pin_1_text;
    public Text pin_2_text;
    public Text pin_3_text;
    [SerializeField] private Text resultText;
    private bool winFlag;

    void Start()
    {
        CreateGame();
    }

    void Update()
    {
        StartTimer();
        RefreshGameData();
    }

    private void StartTimer()
    {
        if (!winFlag)
        {
            if (timeStart > 0f)
            {
                timeStart -= Time.deltaTime;
                timerText.text = Mathf.Round(timeStart).ToString();
            }
            else
            {
                resultText.text = "Вы проиграли!";
                resultPanel.gameObject.SetActive(true);
                ActivateToolsButtons(false);
            }

        }
    }

    private void CreateGame()
    {
        ActivateToolsButtons(true);
        winFlag = false;
        pin_1 = random.Next(10);
        pin_2 = random.Next(10);
        pin_3 = random.Next(10);
    }

    private void RefreshGameData()
    {
        CheckLimitPins();

        pin_1_text.text = pin_1.ToString();
        pin_2_text.text = pin_2.ToString();
        pin_3_text.text = pin_3.ToString();

        if (pin_1 == 6 && pin_2 == 6 && pin_3 == 6)
        {
            resultText.text = "Вы победили!";
            winFlag = true;
            resultPanel.gameObject.SetActive(true);
            ActivateToolsButtons(false);
        }
    }

    public void LockPickButton()
    {
        pin_1 += 2;
        pin_2 += 1;
        pin_3 -= 1;
    }

    public void ScrewdriverButton()
    {
        pin_1 -= 1;
        pin_2 -= 2;
    }

    public void ClipButton()
    {
        pin_1 -= 1;
        pin_2 += 1;
        pin_3 += 2;
    }

    private void CheckLimitPins()
    {
        if (pin_1 > 10) pin_1 = 10;
        if (pin_1 < 0) pin_1 = 0;
        if (pin_2 > 10) pin_2 = 10;
        if (pin_2 < 0) pin_2 = 0;
        if (pin_3 > 10) pin_3 = 10;
        if (pin_3 < 0) pin_3 = 0;
    }

    public void ResetButton()
    {
        resultPanel.gameObject.SetActive(false);
        timeStart = 60f;
        CreateGame();
        ActivateToolsButtons(true);
    }

    public void ActivateToolsButtons(bool status)
    {
        if (!status)
        {
            lockPickButton.gameObject.SetActive(false);
            screwdriverButton.gameObject.SetActive(false);
            clipButton.gameObject.SetActive(false);
        } else
        {
            lockPickButton.gameObject.SetActive(true);
            screwdriverButton.gameObject.SetActive(true);
            clipButton.gameObject.SetActive(true);
        }
    }
}
