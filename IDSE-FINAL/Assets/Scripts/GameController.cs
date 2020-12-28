using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public GameObject gameOverText;
    public GameObject gameWinnerText;
    public bool gameOver;
    public bool gameWinner;
    public float scrollSpeed = -1.5f;
    public float scrollSpeedPeces = -3f;
    static public int nivelDesbloqueado;
    public int nivelActual;
    public Button[] botones;

    void Start()
    {
        if(SceneManager.GetActiveScene().name == "NivelesMenu")
        {
            ActualizarBotones();
        }
    }

    private int score;
    public Text scoreText;

    private void Awake()
    {
        if(GameController.instance == null)
        {
            GameController.instance = this;
        }else if(GameController.instance != this)
        {
            Destroy(gameObject);
            Debug.LogWarning("GameController ha sido instanciado por segunda vez");
        }
    }
    
    public void BuzoScored()
    {
        if (gameOver) return;
        if (SceneManager.GetActiveScene().name == "Nivel_1")
        {
            score++;
            scoreText.text = "Score: " + score;
            if (score >= 10)
            {
                gameWinner = true;
                BuzoWinner();
            }
        }
        if (SceneManager.GetActiveScene().name == "Nivel_2")
        {
            score++;
            scoreText.text = "Score: " + score;
            if (score >= 20)
            {
                gameWinner = true;
                BuzoWinner();
            }
        }

    }

    // Update is called once per frame
    public void DesbloquearNivel()
    {
        if(nivelDesbloqueado < nivelActual)
        {
            nivelDesbloqueado = nivelActual;
            nivelActual++;
        }
    }

    public void BuzoDie()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

    public void BuzoWinner()
    {
        gameWinnerText.SetActive(true);
        gameWinner = true;
        DesbloquearNivel();
    }

    private void OnDestroy()
    {
        if(GameController.instance == this)
        {
            GameController.instance = null;
        }
    }
    public void ActualizarBotones()
    {
        for(int i = 0; i < nivelDesbloqueado+1; i++)
        {
            botones[i].interactable = true;
        }
    }

    public void EscenaMenuNiveles(string nivelOpc)
    {
        SceneManager.LoadScene(nivelOpc);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
