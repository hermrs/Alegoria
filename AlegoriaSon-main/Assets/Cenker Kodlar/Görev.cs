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
    public GameObject Gm2;
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
                görevText.text = "Babanın Anahtarını Bul";

            }
            if (sayac == 2)
            {
                görevText.text = "Işığı Aç";
                GörevYapıldımı(ilkObj);
                hedef.position = ikinciObj.transform.position;
                

            }
            if (sayac == 3)
            {
                görevText.text = "Evi Dolaş ";
                GörevYapıldımı(ikinciObj);
                hedef.position = ucuncuObj.transform.position;
                Gm2.gameObject.SetActive(true);
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

     
 
