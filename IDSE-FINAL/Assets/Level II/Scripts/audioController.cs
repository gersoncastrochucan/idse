using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class audioController : MonoBehaviour
{
    public List<AudioClip> ListaAudioAccion = new List<AudioClip>();
    public List<AudioClip> ListaAudioNivel = new List<AudioClip>();
    public AudioClip AudioBuceador;
    public AudioClip AudioWin;
    public AudioClip AudioLoser;
    AudioSource AudioEffect;
    // Start is called before the first frame update
    public static audioController Instance;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        AudioEffect = this.GetComponent<AudioSource>();
    }
    public void PlaySoundAccion(int i)
    {
        switch (i)
        {
            case 1:
                AudioEffect.PlayOneShot(ListaAudioAccion[1]);
                break;
            case 2:
                AudioEffect.PlayOneShot(ListaAudioAccion[2]);
                break;            
            default:
                break;
        }

               
    }
    public void PlaySoundNivel(int i)
    {
        switch (i)
        {
            case 1:
                AudioEffect.PlayOneShot(ListaAudioNivel[1]);
                break;
            case 2:
                AudioEffect.PlayOneShot(ListaAudioNivel[2]);
                break;
            case 3:
                AudioEffect.PlayOneShot(ListaAudioNivel[3]);
                break;
            default:
                break;
        }


    }
    public void PlaySoundBuceador()
    {
        AudioEffect.PlayOneShot(AudioBuceador);
    }
    public void PlaySoundWin()
    {
        AudioEffect.PlayOneShot(AudioWin);
    }
    public void PlaySoundLoser()
    {
        AudioEffect.PlayOneShot(AudioLoser);
    }
}
