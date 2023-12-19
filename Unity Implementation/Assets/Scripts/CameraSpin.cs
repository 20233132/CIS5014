using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpin : MonoBehaviour
{
    public GameObject spinPoint;
    public AudioSource Swoosh;
    
    public float defaultFOV = 60;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") )
            transform.RotateAround(spinPoint.transform.position, Vector3.down, 15* Time.deltaTime);
        if (Input.GetKey("a"))
            transform.RotateAround(spinPoint.transform.position, Vector3.up, 15 * Time.deltaTime);
        if (Input.GetKeyDown("space"))
        {
            Swoosh.Play();
            GetComponent<Camera>().fieldOfView = (defaultFOV / 2);
        }
        if (Input.GetKeyUp("space"))
            GetComponent<Camera>().fieldOfView = defaultFOV;

    }
   
}
