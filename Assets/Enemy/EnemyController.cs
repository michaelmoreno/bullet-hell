using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 10f;
    public float interval = 5f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Push", interval, interval);
    }

    void Push()
    {
        float x = Random.Range(-1.0f, 1.0f);
        float z = Random.Range(-1.0f, 1.0f);
        Vector3 movement = new Vector3(x, 0.0f, z);
        rb.AddForce(movement.normalized * speed);
    }
    
}
