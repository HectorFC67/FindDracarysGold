using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int puntuacion = 0;

    private void Start()
    {
        puntuacion = 0;
    }

    public void RecogerMoneda()
    {
        puntuacion++;
        ActualizarPuntuacion();
    }

    private void ActualizarPuntuacion()
    {
        // mostrarla en la interfaz de usuario
        Debug.Log("Puntuación: " + puntuacion);//consola
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moneda"))
        {
            Destroy(other.gameObject);
            RecogerMoneda();
        }
    }
}
