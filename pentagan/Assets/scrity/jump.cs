using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
   Rigidbody zipla;

    // Start is called before the first frame update
    void Start()
    {
        zipla = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            zipla.AddForce(new Vector3(0, 10*Time.deltaTime,0));
        }
    }
    
}
