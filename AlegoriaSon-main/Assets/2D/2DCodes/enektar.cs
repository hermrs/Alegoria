using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enektar : MonoBehaviour
{
    public Transform hedef;
    public float menzil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        menzil = Vector3.Distance(transform.position, hedef.position);
    }
    private void OnMouseOver()
    {
        if (menzil <= 2.5f)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(gameObject);
            }
        }
       
    }
   
}
