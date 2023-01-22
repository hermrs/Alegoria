using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Görev : MonoBehaviour
{
    [Header("Görev Ayarları")]
    private GameObject gorev;
    public Text görevText;
    public GameObject ilkObj;
    public GameObject ikinciObj;
    public GameObject ucuncuObj;
    bool basladımı;
    public int sayac;
    // Start is called before the first frame update
    public void GörevYapıldımı(GameObject bbba)
    {

        bbba.gameObject.SetActive(false);

    }
    void Start()
    {
       sayac = 1;
        basladımı = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (basladımı)
        {
            if (sayac == 1)
            {
                görevText.text = "Sigorta Kutusunu Tamir Et";

            }
            if (sayac == 2)
            {
                görevText.text = "Anahtarları Al";
                GörevYapıldımı(ilkObj);
            }
            if (sayac == 3)
            {
                görevText.text = "Koltukların Üstündeki Örtüleri Kaldır";
                GörevYapıldımı(ikinciObj);
                
            }
            if (sayac == 4)
            {
                görevText.text = "Işığı Aç, Güneş Batıyor";
                GörevYapıldımı(ucuncuObj);
            }
        }
    }
     
    private void OnMouseOver()
    {
       
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                sayac++;


            }

        
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rb = hit.collider.attachedRigidbody;
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Görev")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               
                sayac++;


            }

        }

    }
}
