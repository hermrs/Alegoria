using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasyon : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            anim.SetBool("walk", true);

        }
        else
        {
            anim.SetBool("idle", true);
        }


        if (Input.GetKey(KeyCode.D))
        {

            anim.SetBool("walk", true);

        }
        else 
        {
            anim.SetBool("idle", true);
        }
        
    }
}
