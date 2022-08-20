using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{
    public Transform spawn;
    public GameObject norcube;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("sponernorcube",0,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void sponernorcube()
    {
        Instantiate(norcube, spawn);
    }
}
