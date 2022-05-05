using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class walks : MonoBehaviour
{
    [HideInInspector]
 public Animator anim;
  //  Rigidbody ziplama;

    private void Start()
    {
        anim = GetComponent<Animator>();
        //ziplama = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 3);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 3);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 3);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 3);
        }

        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(0, 25 * Time.deltaTime, 0);
        }
         if(Input.GetKeyDown(KeyCode.Space))
           {
               anim.SetTrigger("jump");
           }
           if (Input.GetKeyUp(KeyCode.Space))
           {
               anim.SetTrigger("jump");
           }
       }
          
       /* if(Input.GetKey(KeyCode.Space))
        {
            ziplama.velocity = Vector3.up;
        }*/
    }
    

