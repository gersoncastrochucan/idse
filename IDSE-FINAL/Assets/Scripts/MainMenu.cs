using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
