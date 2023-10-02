using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnInterval = 3.0f;

    void Start()
    {
        // Llamar al método SpawnCoin repetidamente cada spawnInterval segundos.
        InvokeRepeating("SpawnCoin", 0.0f, spawnInterval);
    }

    void SpawnCoin()
    {
        Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        Ray ray = Camera.main.ScreenPointToRay(screenCenter);
        RaycastHit[] hits = Physics.RaycastAll(ray);

        if (hits.Length > 0)
        {
            int randomIndex = Random.Range(0, hits.Length);
            RaycastHit hit = hits[randomIndex];

            Instantiate(coinPrefab, hit.point, Quaternion.identity);
        }
    }
}
