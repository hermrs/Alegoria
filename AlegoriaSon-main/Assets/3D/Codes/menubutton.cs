using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menubutton : MonoBehaviour
{
    public Button menuyedon;
    void Start()
    {
        menuyedon.onClick.AddListener(() => gotomenuback());

        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gotomenuback()
    {
        SceneManager.LoadScene(0);
    }
}
