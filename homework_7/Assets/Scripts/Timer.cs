using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image image;
    public int maxTime;
    public float currentTime;
    public bool Tick;

    void Start()
    {
        image = GetComponent<Image>();
        currentTime = maxTime;
    }

    void Update()
    {
        Tick = false;
        currentTime -= Time.deltaTime;

        if ( currentTime <= 0 )
        {
            Tick = true;
            currentTime = maxTime;
        }

        image.fillAmount = currentTime / maxTime;
    }
}
