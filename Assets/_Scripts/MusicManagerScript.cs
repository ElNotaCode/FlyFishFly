using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagerScript : MonoBehaviour
{

    private AudioSource audioSource;
    [SerializeField] private AudioClip backgroundMusic1;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("musicMute"))
        {
            PlayerPrefs.SetInt("musicMute", 1);
        }

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("musicMute") == 1)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(backgroundMusic1);
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
}
