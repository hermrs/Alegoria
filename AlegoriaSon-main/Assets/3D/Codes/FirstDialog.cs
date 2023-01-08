using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstDialog : MonoBehaviour
{
    public Text firstconv;
    public float firstdist;
    public Transform firstdialog;
    void Start()
    {
        firstconv.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        firstdist = Vector3.Distance(transform.position, firstdialog.position);
        if(firstdist < 10)
        {
            firstconv.enabled = true;
            StartCoroutine(firstdialogcr());
        }
    }
    IEnumerator firstdialogcr()
    {
        yield return new WaitForSeconds(5f);
        firstconv.enabled = false;
        Destroy(gameObject);
    }


}
