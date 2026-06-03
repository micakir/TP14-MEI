using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI textoScore;
    public TextMeshProUGUI textoTimer;
    public GameObject panelWin;
    public GameObject panelGameOver;

    public void UpdateScore(int score)
    {
        textoScore.text = "Score: " + score;
    }

    public void UpdateTimer(float timer)
    {
        textoTimer.text = "Tiempo: " + timer.ToString("0.00");
    }

    public void MostrarPantallaWin()
    {
        panelWin.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        panelGameOver.SetActive(true);
    }

}