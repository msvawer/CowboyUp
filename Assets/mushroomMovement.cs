using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroomMovement : MonoBehaviour, iPooledObjects
{
    public int moveSpeed;

    // Start is called before the first frame update
    

    // Update is called once per frame
    public void OnObjectSpawn()
    {
        moveSpeed = Random.Range(1, 3);
        this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
