using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBackgroundGame : MonoBehaviour
{
    public AudioSource backgroundMusic;
    public Timer timer;
    public CoinCounter coinCounter;
    void Start()
    {
        backgroundMusic.loop = true;
        backgroundMusic.Play();
    }
}
