using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameSettings : MonoBehaviour
{
    static string NameNivelDesbloqueado = "Nivel Desbloqueado";
    public float NivelActual = 0;
    public float NivelDesbloqueado = 0;
    public static GameSettings Instance{ get; private set; }
    public void SetValueNivel(float pos)
    {
        NivelDesbloqueado = pos;
        PlayerPrefs.SetFloat(NameNivelDesbloqueado, NivelDesbloqueado);
    }
    private void Awake()
    {
        NivelDesbloqueado = PlayerPrefs.GetFloat(NameNivelDesbloqueado);
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
}