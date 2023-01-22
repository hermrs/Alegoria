using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Collector collector;
    public GameObject mumisik;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            collector.shard++;
            collector.shardcount.text = " Soul Shard :  " + collector.shard.ToString();
            Destroy(this.gameObject);
            mumisik.SetActive(true);
        }

    }





}
