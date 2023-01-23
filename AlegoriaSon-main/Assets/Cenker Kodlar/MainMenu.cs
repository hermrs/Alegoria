using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button playbt;
    public Button exitbt;
    public void Start()
    {
        playbt.onClick.AddListener(() => playfunc());
        exitbt.onClick.AddListener(() => exitfunc());
        
    }

    public void Update()
    {
        
    }

    public void exitfunc()
    {
        Application.Quit();
    }
    public void playfunc()
    {
        SceneManager.LoadScene(9);
    }


}
