using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Görev : MonoBehaviour
{
    [Header("Görev Ayarları")]
    public Text görevText;
    public GameObject ilkObj;
    public GameObject ikinciObj;
    public GameObject ucuncuObj;
    public GameObject dorduncuObj;
    bool basladımı;
    public int sayac;
    [Header("Uzaklığa Göre Çalışma")]
    public Transform hedef;
    public Transform player;
    public float menzil;

    // Start is called before the first frame update
    public void GörevYapıldımı(GameObject bbba)
    {

        bbba.gameObject.SetActive(false);

    }
    void Start()
    {
        sayac = 1;
        basladımı = true;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        menzil = Vector3.Distance(player.position,hedef.position);
        if (menzil <= 2.5f && Input.GetKeyDown(KeyCode.E))
        {
            sayac++;
        }
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
                hedef.position = ikinciObj.transform.position;
            }
            if (sayac == 3)
            {
                görevText.text = "Koltukların Üstündeki Örtüleri Kaldır";
                GörevYapıldımı(ikinciObj);
                hedef.position = ucuncuObj.transform.position;
            }
            if (sayac == 4)
            {
                görevText.text = "Işığı Aç, Güneş Batıyor";
                GörevYapıldımı(ucuncuObj);
                hedef.position = dorduncuObj.transform.position;
            }
        }

    }
   /* private void PressE()
    {
        if (menzil <= 2.5f && Input.GetKeyDown(KeyCode.E))
        {
                sayac++;
        }

    }*/ 



}

     
 
