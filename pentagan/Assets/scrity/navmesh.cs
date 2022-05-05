using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class navmesh : MonoBehaviour
{
   
    public Transform duvar;
    NavMeshAgent nav;
    public Transform dusman;
    // Start is called before the first frame update
    void Start()
    {
        nav= GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        nav.destination = duvar.position;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Untagged")
        {
            
            dusman.transform.position = new Vector3(-31.669f, 0.4099998f, -9.018f);
            
        }
    }
}
