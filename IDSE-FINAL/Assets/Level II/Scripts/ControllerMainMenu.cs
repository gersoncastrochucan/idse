﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControllerMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public string ScenaNivel;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void JugarButtonClick()
    {
        SceneManager.LoadScene(ScenaNivel);
    }
}
