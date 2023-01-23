using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class jumpscare2 : MonoBehaviour
{
    public GameObject jhumscare;
    void Start()
    {
        jhumscare.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            jhumscare.SetActive(true);
            
        }
    }
    void Update()
    {

    }
   
}
