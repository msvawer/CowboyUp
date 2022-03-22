using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
   

    
    void FixedUpdate()
    {
        ObjectPooler.Instance.SpawnFromPool("Mushroom", transform.position, Quaternion.identity);
    }
}
