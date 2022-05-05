using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roator : MonoBehaviour
{
    public Rigidbody rb;
    float hiz = 4.0f;
    public float geridon;
    bool zamanlayici;
   // float time;
   // float aralik=3.0f;
   
    // Start is called before the first frame update
    void Start()
    {
        geridon = hiz;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.left* geridon;
        //time += Time.deltaTime;
        if (zamanlayici)
        {

            //if (time > aralik)
            //{
                if (geridon > 0)
                {
                geridon = -hiz;
                zamanlayici = false;
                    //time = 0;
                }
                else if (geridon < 0)
                {
                geridon = hiz;
                zamanlayici = false;
                    //time = 0;


                }
            //}
            
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "roater")
        {
            zamanlayici = true;
        }

    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(this.rb.velocity.x, rb.velocity.y, this.rb.velocity.z);
        }
    }
}
