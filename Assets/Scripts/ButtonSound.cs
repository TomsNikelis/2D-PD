using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public AudioSource buttonAudio;
    public AudioClip clickClip;
    public void ClickSound()
    {
        buttonAudio.PlayOneShot(clickClip);
    }
}
