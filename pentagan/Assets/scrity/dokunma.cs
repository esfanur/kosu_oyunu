using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dokunma : MonoBehaviour
{
    public GameObject game;
    
    public Transform oyuncu;
    float simdi_can = 100.0f;
    float canbar = 100.0f;
    public Image canbari;
   
    // Start is called before the first frame update
    private void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Untagged")
        {
            simdi_can -= 10.0f;
            canbari.fillAmount = simdi_can / canbar;
            if(simdi_can==0)
            {
                Time.timeScale = 0.0f;
                oyuncu.transform.position = new Vector3(-31.669f, 0.4099998f, -9.018f);
                game.SetActive(true);
            }
        }
        
    }
   
}
