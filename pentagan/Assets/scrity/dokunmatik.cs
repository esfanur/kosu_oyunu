using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dokunmatik : MonoBehaviour
{
    Rigidbody karkater;
    bool sag;
    bool sol;
    float hiz = 5f;
    float zipla = 4f;

    // Start is called before the first frame update
    void Start()
    {
        karkater = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, hiz * Time.deltaTime);
        Vector3 sag_git = new Vector3(-4.52f, transform.position.y, transform.position.z);
        Vector3 sol_gti = new Vector3(-13.11f, transform.position.y, transform.position.z);
        if(Input.touchCount>0)
        {
            Touch parmak = Input.GetTouch(0);
            if(parmak.deltaPosition.x>50f)
            {
                sag = true;
                sol = false;
            }
            if (parmak.deltaPosition.x < -50f)
            {
                sag = false;
                sol = true;
            }
            if(parmak.deltaPosition.y>50f)
            {
                karkater.velocity = Vector3.zero;
                karkater.velocity = Vector3.up*zipla;
            }
            if(sag==true)
            {
                transform.position = Vector3.Lerp(transform.position, sag_git, hiz * Time.deltaTime);
            }
            if (sol == true)
            {
                transform.position = Vector3.Lerp(transform.position, sol_gti, hiz * Time.deltaTime);
            }

        }
        
    }
  
}
