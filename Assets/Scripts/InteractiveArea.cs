using UnityEngine;
using TMPro;

public class InteractiveArea : MonoBehaviour
{
    public TextMeshProUGUI textoContador;
    public int puntajeMaximo = 6;
    int contador = 0;

    UImanager uiManager;
    GameM gameManager;

    void Start()
    {
        uiManager = FindObjectOfType<UImanager>();
        gameManager = FindObjectOfType<GameM>();
        textoContador.text = "Score: 0";
    }

    public void SumarPunto()
    {
        contador++;
        textoContador.text = "Score: " + contador;

        if (contador == puntajeMaximo)
        {
            gameManager.juegoTerminado = true;
            uiManager.MostrarPantallaWin();
            Time.timeScale = 0;
        }
    }
}