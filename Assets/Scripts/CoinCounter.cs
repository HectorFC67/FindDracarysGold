using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class CoinCounter : MonoBehaviour
{
    private float puntos = 0;
    public TextMeshProUGUI textoPuntuacionPro;
    public Image imagen;
    public Joystick[] joysticks;
    public TextMeshProUGUI[] textos;

    private void Start()
    {
        textoPuntuacionPro = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        textoPuntuacionPro.text = puntos.ToString();
        if(puntos > 19)
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

    public void SumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
    }
}
