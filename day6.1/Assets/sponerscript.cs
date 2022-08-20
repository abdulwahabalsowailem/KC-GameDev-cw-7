using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sponerscript : MonoBehaviour
{
    public float time;

    public Transform leftpos;
    public Transform rightpos;
    public Transform midpos;

    public GameObject norcube;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("sponer",0f,time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void sponer()
    {
        int randompos = Random.Range(1, 4);

        if(randompos ==1)
        {
            Instantiate(norcube, leftpos);

        }
        else if (randompos == 2)
        {
            Instantiate(norcube, rightpos );
        }
        else 
        {
            Instantiate(norcube, midpos);
        }
        
    }
}
