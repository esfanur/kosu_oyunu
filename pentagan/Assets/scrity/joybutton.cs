using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class joybutton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    [HideInInspector]
    public bool basma;
    // Start is called before the first frame update
   

    public void OnPointerDown(PointerEventData eventData)
    {
        basma = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        basma = false;
    }


}

