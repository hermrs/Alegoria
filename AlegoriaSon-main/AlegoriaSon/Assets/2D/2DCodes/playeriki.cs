using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeriki : MonoBehaviour
{
    public float MoveX;
    public float MoveZ;
    public SpriteRenderer spriteRenderer;
    public CharacterController cc;
    public float speed = 5;
    void Start()
    {
        cc = GetComponent<CharacterController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        cc.Move(move  *Time.deltaTime * speed);
        donme();
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
