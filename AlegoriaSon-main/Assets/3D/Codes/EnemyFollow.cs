using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollow : MonoBehaviour
{
    NavMeshAgent agent;
    
    Animator creatureanim;
    public Transform Target;
    public float mesafe;
    public GameObject chasesound;
    void Start()
    {
        
    agent = GetComponent<NavMeshAgent>();
    creatureanim = GetComponent<Animator>();   
    
    }

    // Update is called once per frame
    void Update()
    {
        creatureanim.SetFloat("hiz", agent.velocity.magnitude);
        
        mesafe = Vector3.Distance(transform.position, Target.position);
        
        if (mesafe <= 20)
        {
            chasesound.SetActive(true);
            agent.enabled = true;
            agent.destination = Target.position;
        }
        else
        {
            agent.enabled = false;
            chasesound.SetActive(false);
           
        }
        if(mesafe < 3)
        {
            creatureanim.SetBool("attack", true);
        }
        else
        {
            creatureanim.SetBool("attack", false);
        }
        
    }
}
