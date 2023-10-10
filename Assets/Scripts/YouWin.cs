using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class YouWin : MonoBehaviour
{
    public Button restartButton;
    public Button mainMenuButton;

    private void Start()
    {
        restartButton.onClick.AddListener(RestartGame);
        mainMenuButton.onClick.AddListener(ReturnToMainMenu);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
