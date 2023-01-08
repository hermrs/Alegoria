using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    public bool flashlightwork = false;
    public GameObject fener;
    void Start()
    {
        
    }

    
    void Update()
    {
       if(flashlightwork == false)
        {
            fener.SetActive(false);
        }
       if(flashlightwork == true)
        {
            fener.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlightwork = !flashlightwork;
        }

        
    }
    
    }



