using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondDialog : MonoBehaviour
{
    public Text firstd;
    public Text secondd;
    public Text thirdd;
    public float seconddist;
    public Transform seconddialog;
    void Start()
    {
        firstd.enabled = false;
        secondd.enabled = false;
        thirdd.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
        seconddist = Vector3.Distance(transform.position, seconddialog.position);
        if(seconddist < 5)
        {
            
            
            StartCoroutine(firstcon());
        }

    }
    IEnumerator firstcon()
    {
        firstd.enabled = true;
        StopCoroutine(firstcon());
        yield return new WaitForSeconds(4f);
        
        firstd.enabled=false;
        secondd.enabled = true;
        StartCoroutine(secondcon());    
    }
    IEnumerator secondcon()
    {
        StopCoroutine(secondcon());
        yield return new WaitForSeconds(4f);
        
        secondd.enabled=false;
        thirdd.enabled = true;
        StartCoroutine(thirdcon()); 
    }
    IEnumerator thirdcon()
    {
        StopCoroutine(thirdcon());
        yield return new WaitForSeconds(4f);
        thirdd.enabled = false;
        
        Destroy(gameObject);

    }

}