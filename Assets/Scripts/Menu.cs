using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource backgroundMusic;

    void Start()
    {
        backgroundMusic.loop = true;
        backgroundMusic.Play();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Juego");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
