using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class halfdon : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float forspeed;
    bool timer;
   

    // Start is called before the first frame update
    void Start()
    {
        forspeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.forward * forspeed;
        if (timer)
        {
                if (forspeed > 0)
                {
                    forspeed = -speed;
                    timer = false;
                    
                }
                else if (forspeed < 0)
                {
                    forspeed = speed;
                    timer = false;
                    
                }
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="alt")
        {
            timer = true;
        }

        if (collision.gameObject.tag == "Untagged")
        {
            timer = true;
        }

        //SceneManager.LoadScene("sahne");
    }
    
    
  
}
