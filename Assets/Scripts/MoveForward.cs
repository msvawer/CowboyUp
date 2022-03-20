using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public int enemySpeed;
    //Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        // m_Rigidbody = GetComponent<Rigidbody>();
        enemySpeed = Random.Range(2, 10);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.right * Time.deltaTime * enemySpeed);
    }
}
