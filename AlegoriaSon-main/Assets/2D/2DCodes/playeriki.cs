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
    public Text g�rev31;
    public GameObject �lkG�rev;
    public GameObject �kinci;
    public GameObject Ucuncu;
    public int sayac;
    //public AudioSource au;
    
    void Start()
    {
        cc = GetComponent<CharacterController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        //au = GetComponent<AudioSource>(); 
        sayac = 2;
        g�rev31.text = "Bula��k";
       // au.enabled = false;
    }
   
    private void Awake()
    {
        
    }

    public void G�revYap�ld�m�(GameObject bbba)
    {
        
            bbba.gameObject.SetActive(false);
        
    }
    // Update is called once per frame
   
    void Update()
    {

       
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        cc.Move(move  *Time.deltaTime * speed);
        donme();
        //if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
        //    au.enabled = true;
        //}
        //else
        //{
        //    au.enabled = false;
        //}
        g�rev31.text = "Bula��k";
        if (sayac == 1)
        {
            g�rev31.text = "Bula��k";
           
            
            
        }
        if (sayac == 2 )
        {
            g�rev31.text = "2.g�rev";
            G�revYap�ld�m�(�lkG�rev);
        }
        if (sayac == 3 )
        {
            g�rev31.text = "3.g�rev";
            G�revYap�ld�m�(�kinci);
        }
        if (sayac == 4 )
        {
            g�rev31.text = "4.g�rev";
            G�revYap�ld�m�(Ucuncu);
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
        if (other.gameObject.tag == "G�rev")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                gorev.SetActive(true);
                sayac++;
                
                
            }

        }

    }
}
