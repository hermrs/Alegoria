using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class jumpscare : MonoBehaviour
{
    
    public GameObject humscare;
    void Start()
    {
        humscare.SetActive(false); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "3DPlayer")
        {
            humscare.SetActive(true);
            StartCoroutine(JumpscareCR());
        }
    }
    void Update()
    {
        
    }
    IEnumerator JumpscareCR()
    {
        

        yield return new WaitForSeconds(0.8f);
        humscare.SetActive(false);
        Destroy(gameObject);


    }
}
