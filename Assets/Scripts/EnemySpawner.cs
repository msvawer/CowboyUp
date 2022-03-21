using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public GameObject enemyContainer;

    int spawnRateSeconds;

    Vector3 randomPosEnemy;

    int yRange;
    int zRange; 

    // Start is called before the first frame update
    void Start()

    {
        yRange = Random.Range(3, 5);
        zRange = Random.Range(-3, 10);
        randomPosEnemy = new Vector3(-14, yRange, zRange);
        spawnRateSeconds = Random.Range(1, 5);

        GameObject enemyPrefab = ObjectPool.SharedInstance.GetPooledObject();
        if (enemyPrefab != null)
        {
            enemyPrefab.transform.position = randomPosEnemy;
            enemyPrefab.transform.rotation = Quaternion.identity;
            enemyPrefab.SetActive(true);
        }

        StartCoroutine(SpawnEnemies());
    }



    IEnumerator SpawnEnemies()
    {
     while (true)
    {
    GameObject enemyPrefab = ObjectPool.SharedInstance.GetPooledObject();
        if (enemyPrefab != null)
        {
            enemyPrefab.transform.position = randomPosEnemy;
            enemyPrefab.transform.rotation = Quaternion.identity;
            enemyPrefab.SetActive(true);
        }
           //Instantiate(enemyPrefab, randomPosEnemy, Quaternion.identity);

          yield return new WaitForSeconds(spawnRateSeconds);
        }
  }

    
}
