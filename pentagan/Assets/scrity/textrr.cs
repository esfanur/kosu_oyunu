using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textrr : MonoBehaviour
{
    
    public int altin_mik;
    public Text skor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void OnTriggerEnter(Collider other)
    {
        altin_mik++;
        skor.text = altin_mik.ToString();
      
    }

}
