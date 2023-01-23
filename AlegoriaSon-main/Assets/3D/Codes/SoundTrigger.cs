using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public GameObject ads;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "3DPlayer")
        {
            ads.SetActive(true);
            StartCoroutine(soundcloser());
        }
    }
    IEnumerator soundcloser()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
