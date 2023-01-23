using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enektar : MonoBehaviour
{
    public Transform hedef;
    public float menzil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        menzil = Vector3.Distance(transform.position, hedef.position);
    }
    private void OnMouseOver()
    {
        if (menzil <= 2.5f)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                gameObject.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (gameObject.name == "SalonKapi")
            {
                SceneManager.LoadScene(3);
            }
            if (gameObject.name == "MutfakKapi")
            {
                SceneManager.LoadScene(2);
            }
            if (gameObject.name == "KilerKapi")
            {
                SceneManager.LoadScene(4);
            }
            if (gameObject.name == "KoridorKapi")
            {
                SceneManager.LoadScene(1);
            }
            if(gameObject.name == "KoridorKapi2")
            {
                SceneManager.LoadScene(7);
            }
            if(gameObject.name == "KilerKapi2")
            {
                SceneManager.LoadScene(8);
            }
        }

    }
    
   
}
