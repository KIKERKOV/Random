using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    private AudioSource _audioSource;

    public void RickRoll()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.Play(0);
        Debug.Log("started");
    }

}
