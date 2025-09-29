using UnityEngine;
using UnityEngine.AI;
public class DrainerMovement : MonoBehaviour
{
    public Transform Player;
    private NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        if (Player != null)
        {
            navMeshAgent.SetDestination(Player.position);
        }

    }
}
