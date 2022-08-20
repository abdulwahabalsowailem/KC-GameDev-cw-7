using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour
{
    public float inc;
    public int min;
    public int max;
  public  AudioSource src;

    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        move();
         
        
    }
    void move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, min, max), transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x  -inc, min, max), transform.position.y, transform.position.z);

        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision .gameObject .tag == "norcube")
        {
            SceneManager.LoadScene(0);
            src.Play();
            Invoke("restart",1f) ;
        }
        
    }
    void restart()
    {
        SceneManager.LoadScene(0);
    }
}
