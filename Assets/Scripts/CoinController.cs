using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private CoinCounter puntuacion;
    [SerializeField] private AudioClip sonidoMoneda;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        audioSource.clip = sonidoMoneda;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            puntuacion.SumarPuntos(cantidadPuntos);
            ReproducirSonido();
            Destroy(this.gameObject);
        }
    }

    private void ReproducirSonido()
    {
        if (audioSource != null && sonidoMoneda != null)
        {
            audioSource.PlayOneShot(sonidoMoneda);
        }
    }
}
