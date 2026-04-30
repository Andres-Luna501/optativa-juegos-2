using UnityEngine;
using System.Collections;

public class ParedSpawner : MonoBehaviour
{
    public GameObject paredPrefab;
    public Transform spawnPoint;

    public float spawnDelay = 2f;      // tiempo base
    public float randomDelay = 1.5f;   // variación

    public float rangeX = 2f;          // qué tanto se mueve en horizontal

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            SpawnPared();

            float waitTime = spawnDelay + Random.Range(0f, randomDelay);
            yield return new WaitForSeconds(waitTime);
        }
    }

    void SpawnPared()
    {
        Vector3 pos = spawnPoint.position;

        // Variación horizontal (caos elegante)
        pos.x += Random.Range(-rangeX, rangeX);

        Instantiate(paredPrefab, pos, Quaternion.identity);
    }
}