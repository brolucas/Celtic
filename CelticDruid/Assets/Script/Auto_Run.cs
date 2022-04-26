using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_Run : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
