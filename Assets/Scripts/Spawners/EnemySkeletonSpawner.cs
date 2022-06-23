using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkeletonSpawner : MonoBehaviour
{
    public GameObject SkeletonPrefab;
    public GameObject Spawner;

    private void Start()
    {
        StartCoroutine(EnemyMave());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(SkeletonPrefab) as GameObject;
        a.transform.position = new Vector2(Spawner.transform.position.x, Spawner.transform.position.y);
    }

    IEnumerator EnemyMave()
    {
        while (true)
        {
            float x = Random.Range(3f, 4.5f);
            yield return new WaitForSeconds(x);
            spawnEnemy();
        }
    }
}
