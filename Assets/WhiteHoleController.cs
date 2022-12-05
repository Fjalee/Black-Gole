using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteHoleController : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        audioSource.Play();
    }
}
