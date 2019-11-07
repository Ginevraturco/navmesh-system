using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    private NavMeshAgent _agent;

    private GameObject _player;

    private void Start()
    {
        // Find the navmesh agent component
        _agent = GetComponent<NavMeshAgent>();

        // Find the player gameobject in scene
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        // moves toward the player, updating the destination each frame
        _agent.destination = _player.transform.position;
    }
}
