using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer = 0;
    public TextMeshProUGUI textoTimerPro;
    public Image imagen;
    public Joystick[] joysticks;
    public TextMeshProUGUI[] textos;

    void Update()
    {
        timer -= Time.deltaTime;
        textoTimerPro.text = timer.ToString("f1");

        if (timer < 0.1)
        {
            foreach (Joystick joystick in joysticks)
            {
                joystick.enabled = false;
            }

            foreach (TextMeshProUGUI texto in textos)
            {
                texto.gameObject.SetActive(false);
            }

            imagen.gameObject.SetActive(true);
        }
    }
}
