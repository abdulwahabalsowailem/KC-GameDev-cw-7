using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class norcubescript : MonoBehaviour
{
    Rigidbody RB;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RB.velocity = new Vector3(0, 0, speed);
    }
}
