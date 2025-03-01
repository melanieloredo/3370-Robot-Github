using System.Collections; //unity engines libraries
using System.Collections.Generic;
using UnityEngine;

public class Hello_world : MonoBehaviour
{
    // Start is called before the first frame update
    //initial setup and always executed 1 time
    //first frame calls the start method
    void Start()
    {
        Debug.Log("Hello World"); //print function
    }

    // Update is called once per frame
    //updates per frame
    //here where the user presses buttons
    void Update()
    {
        Debug.Log("Updating!");
    }
}
