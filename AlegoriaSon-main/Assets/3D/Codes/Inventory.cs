using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Collector collector;
    public GameObject mumisik;
    public bool clickability = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseOver()
    {
        if (clickability == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                clickability = false;
                collector.shard++;
                collector.shardcount.text = " Ruh Parçasý :  " + collector.shard.ToString();
                Destroy(this.gameObject);
                mumisik.SetActive(true);
            }
        }
    }





}
