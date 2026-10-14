using UnityEngine;
using UnityEngine.AI;

public class nava : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform Target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.updateRotation = false;

        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Target.position);
    }
}

