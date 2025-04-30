using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieNPC : MonoBehaviour
{
    //C. Getting the animator
    Animator animator;

    //C. NCP naviagion target goal
    public Transform goal;

    //C. Getting navmeshagent
    private NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStandUpAnimationEnd()
    {
        Debug.Log("Zombies finished standing up");
        agent.destination = goal.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("isClose", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("isClose", false);
        }
    }

}
