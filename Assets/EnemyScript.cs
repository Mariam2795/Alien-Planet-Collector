using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    private Transform goal;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        goal = Camera.main.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        GetComponent<Animation>().Play("Alien@idle_pose_with_a_gun");
    }

    // Update is called once per frame
    void Update()
    {
        goal = Camera.main.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        GetComponent<Animation>().Play("Alien@idle_pose_with_a_gun");
    }

    public void Zombie_dead()
    {
        agent.isStopped = true;
        GetComponent<AudioSource>().Play();
        GetComponent<Animation>().Stop();
        GetComponent<Animation>().Play("dead");
        Destroy(gameObject, 3);
    }

    public void Call_Gun()
    {
        StartCoroutine(GunAnimationCoroutine());
    }
    private IEnumerator GunAnimationCoroutine()
    {
        // Play gun animation
        GetComponent<Animation>().Play("GunAnimation");
        // Wait for the gun animation to finish

        yield return new

        WaitForSeconds(GetComponent<Animation>()["GunAnimation"].length);

        // Resume zombie animation
        GetComponent<Animation>().Play("Z_Walk_InPlace");
    }

}
