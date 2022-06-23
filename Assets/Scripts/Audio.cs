using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource music;
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject stopButton;
    int x = 1;

    private void Start()
    {
        music.Play();
    }

    public void PlayMusic()
    {
        if (x == 0)
        {
            for (int i = 0; i < 1; i++)
            {
                x++;
                music.Play();
                playButton.SetActive(false);
                stopButton.SetActive(true);
            }
        }
        
    }

    public void StopMusic()
    {
        if (x == 1)
        {
            for (int i = 0; i < 1; i++)
            {
                x--;
                music.Pause();
                playButton.SetActive(true);
                stopButton.SetActive(false);
            }
        }
    }
}
