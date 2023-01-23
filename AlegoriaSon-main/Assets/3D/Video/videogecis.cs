using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class videogecis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(geciszamanlayicisi());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator geciszamanlayicisi()
    {
        yield return new WaitForSeconds(39f);
        SceneManager.LoadScene("2DKoridor1", LoadSceneMode.Single);
    }




}
