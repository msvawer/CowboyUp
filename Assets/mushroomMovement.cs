using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroomMovement : MonoBehaviour
{
    public int moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = Random.Range(5, 10);
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = Random.Range(5, 10);
        this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
