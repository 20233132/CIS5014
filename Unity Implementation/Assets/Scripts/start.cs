using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public AudioSource clicky;
    // Start is called before the first frame update
    public void OnBeginButton () 
    {
        clicky.Play();

        Invoke("load", 1);
        

    }
    void load()
    { SceneManager.LoadScene(1); }
}
