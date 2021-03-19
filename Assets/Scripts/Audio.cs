using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public AudioSource voiceLine1Source;
    public AudioSource voiceLine2Source;
    public AudioClip voiceLine1Clip;
    public AudioClip voiceLine2Clip;
    public void HangleInputData(int value)
    {
        if(value == 0)
        {
            voiceLine1Source.PlayOneShot(voiceLine1Clip);
            Debug.Log(value);
        }
        if (value == 1)
        {
            voiceLine2Source.PlayOneShot(voiceLine2Clip);

        }
    }
}
