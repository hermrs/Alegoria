using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class etkilesim : MonoBehaviour
{

    public bool toplama = false;
    [SerializeField] private GameObject gizlianahtar;
   
   

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Toplanacak")
        if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(col.gameObject);
                toplama = true;
            }
        if (toplama == true)
        {
            gizlianahtar.SetActive(true);
        }
    

        if (col.gameObject.tag == "Kapi")
        {

            if (Input.GetKeyDown(KeyCode.E) && toplama)
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                toplama = false;
            }
        }
    }
    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Toplanacak")
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(col.gameObject);
                toplama = true;
            }
        if (toplama == true)
        {
            gizlianahtar.SetActive(true);
        }

        if (col.gameObject.tag == "Kapi")
        {
            if (Input.GetKeyDown(KeyCode.E) && toplama)
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                toplama = false;
            }
        }
    }
}
