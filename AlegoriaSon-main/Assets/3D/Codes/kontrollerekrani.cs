using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kontrollerekrani : MonoBehaviour
{
    public Button acacak;
    public Button kapatacak;
    public GameObject kontrollerpaneli;
    void Start()
    {
        acacak.onClick.AddListener(() => kontrolacar());
        kapatacak.onClick.AddListener(() => kontrolkapar());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void kontrolacar()
    {
        kontrollerpaneli.SetActive(true);
    }
    public void kontrolkapar()
    {
        kontrollerpaneli.SetActive(false);
    }

}
