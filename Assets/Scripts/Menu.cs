using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene("Juego");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
