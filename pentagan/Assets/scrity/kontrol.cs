using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol : MonoBehaviour
{
    
    public joybutton joybutn;
    protected bool jump;
    Rigidbody ribi;
     
    // Start is called before the first frame update
    void Start()
    {
        
        joybutn = FindObjectOfType<joybutton>();
        ribi = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if(!jump && joybutn.basma)
        {
            jump = true;
            ribi.velocity += Vector3.up * 20f;
        }
        else if(jump && !joybutn.basma)
        {
            jump = false;
            
        }
    }
    
}
