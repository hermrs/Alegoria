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
    private Animator anim;
   
    //public AudioSource au;
    
    void Start()
    {
        cc = GetComponent<CharacterController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        //au = GetComponent<AudioSource>(); 
        anim = GetComponent<Animator>();
       // au.enabled = false;
    }
   
    private void Awake()
    {
    }

    
    // Update is called once per frame
   
    void Update()
    {
       

            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        cc.Move(move  *Time.deltaTime * speed);
        donme();
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }
        //if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
        //    au.enabled = true;
        //}
        //else
        //{
        //    au.enabled = false;
        //}

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
    
}
