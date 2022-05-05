using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duvarboya : MonoBehaviour
{
    [SerializeField] private Renderer duvar;
    // Start is called before the first frame update
   

    // Update is called once per frame
   /* private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            duvar.material.color = Color.red;
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            duvar.material.color = Color.red;
        }
    }
}
