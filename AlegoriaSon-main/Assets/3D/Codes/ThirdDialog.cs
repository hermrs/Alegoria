using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class ThirdDialog : MonoBehaviour
{
    public Text replik;
    public bool repliksoylenebilir = true;
    void Start()
    {
        replik.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseOver()
    {
        if ((Input.GetMouseButtonDown(0)) && repliksoylenebilir == true)
        {
            repliksoylenebilir = false;
            StartCoroutine(replikpalyaco());
        }

    }

    IEnumerator replikpalyaco()
    {
        replik.enabled = true;
        yield return new WaitForSeconds(5f);
        replik.enabled = false;
        Destroy(gameObject);
    }

}
