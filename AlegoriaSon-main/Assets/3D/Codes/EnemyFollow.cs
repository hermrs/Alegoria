using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollow : MonoBehaviour
{
    NavMeshAgent agent;
    
    Animator creatureanim;
    public Transform Target;
    public float mesafe;
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
            
            agent.enabled = true;
            agent.destination = Target.position;
        }
        else
        {
            agent.enabled = false;
           
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
