using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playeriki : MonoBehaviour
{
    public float MoveX;
    public float MoveZ;
    public SpriteRenderer spriteRenderer;
    public CharacterController cc;
    public float speed = 5;
    public GameObject gorev;
    public Text görev31;
    public GameObject ÝlkGörev;
    public GameObject Ýkinci;
    public GameObject Ucuncu;
    public int sayac;
    
    void Start()
    {
        cc = GetComponent<CharacterController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        sayac = 2;
        görev31.text = "Bulaþýk";

    }

    public void GörevYapýldýmý(GameObject bbba)
    {
        
            bbba.gameObject.SetActive(false);
        
    }
    // Update is called once per frame
   
    void Update()
    {
        
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        cc.Move(move  *Time.deltaTime * speed);
        donme();
        
        görev31.text = "Bulaþýk";
        if (sayac == 1)
        {
            görev31.text = "Bulaþýk";
           
            
            
        }
        if (sayac == 2 )
        {
            görev31.text = "2.görev";
            GörevYapýldýmý(ÝlkGörev);
        }
        if (sayac == 3 )
        {
            görev31.text = "3.görev";
            GörevYapýldýmý(Ýkinci);
        }
        if (sayac == 4 )
        {
            görev31.text = "4.görev";
            GörevYapýldýmý(Ucuncu);
        }
    }
    /*public void hareged(float MoveX, float MoveZ, GameObject oyuncu)
    {
       MoveX = Input.GetAxis("Horizontal");
        MoveZ = Input.GetAxis("Vertical");
        oyuncu.transform.position = oyuncu.transform.position + new Vector3(MoveX * 10f * Time.deltaTime, 0, MoveZ * 10f * Time.deltaTime);
}*/
    public void donme()
    {
        if (Input.GetKey(KeyCode.A)) { spriteRenderer.flipX = true; }
        if (Input.GetKey(KeyCode.D)) { spriteRenderer.flipX = false; }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Görev")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                gorev.SetActive(true);
                sayac++;
                
                
            }

        }

    }
}
