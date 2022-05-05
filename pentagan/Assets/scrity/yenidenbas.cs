using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yenidenbas : MonoBehaviour
{
    public GameObject gang;
   
    
    // Start is called before the first frame update


    public void baslat()
    {
        gang.SetActive(false);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("platform");
        Time.timeScale = 1;

    }
    public void cik()
    {
        Application.Quit();
    }
    
}
