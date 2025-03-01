using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class prompt : MonoBehaviour
{

    public static prompt instance;

    public TMP_Text prompt_text;

    private void Awake() //executed before first frame of our game
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            prompt_text.text = " ";
        }
    }
}

