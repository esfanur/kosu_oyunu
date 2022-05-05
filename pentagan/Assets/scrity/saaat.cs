using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class saaat : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector]
    public float saat, dakik, saniye;
    public Text clok;

    // Update is called once per frame
    void Update()
    {
        clok.text = " "+saat.ToString("00")+":"+dakik.ToString("00")+":"+saniye.ToString("00");
        saniye += Time.deltaTime;
        
        if (saniye>59)
        {
            dakik += 1;
            saniye = 0;
        }
        if(dakik>=60)
        {
            saat += 1;
            dakik = 0;
        }
    }
}
