using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameM : MonoBehaviour
{

    public float timer = 60f;
    UImanager uiManager;
    public bool juegoTerminado = false;

    void Awake()
    {
        uiManager = FindObjectOfType<UImanager>();
    }

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (!juegoTerminado)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = 0;
                juegoTerminado = true;
                uiManager.MostrarPantallaGameOver();
                Time.timeScale = 0;
            }
            uiManager.UpdateTimer(timer);
        }

        if (juegoTerminado && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}