using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameM : MonoBehaviour
{
    public float timer = 60f;

    UImanager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UImanager>();
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            timer = 0;
        }

        uiManager.UpdateTimer(timer);
    }
}