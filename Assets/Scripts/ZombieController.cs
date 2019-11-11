using UnityEngine;
using UnityEngine.AI;
using UnityEditor;

public class ZombieController : MonoBehaviour
{
    private NavMeshAgent _agent;

    private GameObject _player;

    public float smellSense = 5;

    public Animator brain;

    private bool _isSeeking;
    private void Start()
    {
        // Find the navmesh agent component
        _agent = GetComponent<NavMeshAgent>();

        // Find the player gameobject in scene
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        var distanceToTarget = Vector3.Distance(
            transform.position, 
            _player.transform.position
            );

        if(distanceToTarget < smellSense)
        {
            // moves toward the player, updating the destination each frame
            _agent.destination = _player.transform.position;
            _isSeeking = true;
        }
        else
        {
            _isSeeking = false;
        }

    }

    private void OnDrawGizmosSelected()
    {
        if(_isSeeking)
        {
            Handles.color = new Color(1f, 0f, 0f, 0.1f);
        }
        else
        {
            Handles.color = new Color(0f, 1f, 0f, 0.1f);
        }
        Handles.DrawSolidDisc(transform.position, Vector3.up, smellSense);
    }
}
