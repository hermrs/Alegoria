using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class arttırma : MonoBehaviour
{
    public TMP_Text text_kup;
    public TMP_Text text_silindir;
    public TMP_Text text_kure;

    int kup;
    int silindir;
    int kure;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    private void arttır(TMP_Text sko,int sayı)
    {
        
        
            sayı++;
            sko.text = sayı.ToString();
            gameObject.SetActive(false);
        
    }
    private void OnMouseDown()
    {
        if (gameObject.name=="silindir")
        {
            arttır(text_silindir, silindir);
        }
        if (gameObject.name == "kure")
        {
            arttır(text_kure, kure);
        }
        if (gameObject.name == "kup")
        {
            arttır(text_kup, kup);
        }

    }
  
}
