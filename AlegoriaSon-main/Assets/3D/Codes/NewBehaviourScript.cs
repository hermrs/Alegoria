using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float MoveX;
    public float MoveZ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hareged(MoveX, MoveZ, gameObject);
        donme();
    }
    public void hareged(float MoveX, float MoveZ, GameObject Karakter)
    {
        MoveX = Input.GetAxis("Horizontal");
        MoveZ = Input.GetAxis("Vertical");
        Karakter.transform.position = Karakter.transform.position + new Vector3(MoveX * 10f * Time.deltaTime, 0, MoveZ * 10f * Time.deltaTime);
    }
    public void donme()
    {
        
        if (Input.GetKey(KeyCode.A)) { transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -90, 0), .02f); }
        if (Input.GetKey(KeyCode.D)) { transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), .02f); }
        if (Input.GetKey(KeyCode.W)) { transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 360, 0), .02f); }
        if (Input.GetKey(KeyCode.S)) { transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -180, 0), .02f); }
    }
}
