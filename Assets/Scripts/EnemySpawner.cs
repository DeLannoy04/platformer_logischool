using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyController enemyPrefab;
    [SerializeField] private float spawnRate;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        Vector3 spawnPoint = new Vector3(Random.Range(-2f, 2f), 0, 0);
        spawnPoint += transform.position;

        while (true)
        {
            Instantiate(enemyPrefab, spawnPoint, Quaternion.identity, transform);
            yield return new WaitForSeconds(3 / spawnRate);
        }
    }
}
