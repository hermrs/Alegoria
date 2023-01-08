using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    
    public Button restarter;
    public AudioSource ded;
   
    
    void Start()
    {
        ded.Play();
        restarter.onClick.AddListener(() => RestartDaGame());
        

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void RestartDaGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
