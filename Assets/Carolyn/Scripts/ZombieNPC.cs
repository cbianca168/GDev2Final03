using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class ZombieNPC : MonoBehaviour
{
    //C. Getting the animator
    Animator animator;

    //C. NCP naviagion target goal
    private Transform goal;

    //C. Getting navmeshagent
    private NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            goal = player.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //C. Waiting for the stand up animation to be complete before npc follows player
    public void OnStandUpAnimationEnd()
    {
        Debug.Log("Zombies finished standing up");
        agent.destination = goal.position;
    }

    
    //C. Transitions animation to the attack animation
    //C. Also checks for player attack
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            Animator playerAnimator = other.GetComponent<Animator>();
            if (playerAnimator != null)
            {
                AnimatorStateInfo stateInfo = playerAnimator.GetCurrentAnimatorStateInfo(0);
                if (stateInfo.IsName("JumpStart") || stateInfo.IsName("InAir") || stateInfo.IsName("JumpLand"))
                {
                    Die();
                }
            }
            animator.SetBool("isClose", true);
        }
    }

    //C. Transitions animation back to running animation
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("isClose", false);
        }
    }

    public void Die()
    {
        animator.SetBool("isDead", true);
        //OnDyingAnimationEnd();
        //OnDeathAnimationEnd();
    }

    public void OnDyingAnimationEnd()
    {
        Destroy(gameObject);
    }

    public void OnDeathAnimationEnd()
    {
        Destroy(gameObject);
    }

}
