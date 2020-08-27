using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource carCrash;
    public AudioSource carEnter;

    public void carCrashTurnOn()
    {
        if(carCrash.isPlaying == false)
        {
            carCrash.Play();
         //   Debug.Log("Çalıyor");
        }
    }

    public void carEnterTurnOn()
    {
        if(carEnter.isPlaying == false)
        {
            carEnter.Play();
        }
    }
}
