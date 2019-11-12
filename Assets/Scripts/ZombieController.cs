using UnityEngine;
using UnityEngine.AI;
using UnityEditor;

public class ZombieController : MonoBehaviour
{
    private NavMeshAgent _agent;

    private GameObject _player;

    // The distance used by the zombie to find a target
    public float smellSense = 5;

    // A state that shows if the zombie is seeking the player
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
        // Find the distance to the player
        var distanceToTarget = Vector3.Distance(
            transform.position, 
            _player.transform.position
            );

        // If the player is within range ...
        if(distanceToTarget < smellSense)
        {
            // ... move toward the player, updating the destination each frame
            _agent.destination = _player.transform.position;
            _isSeeking = true;
        }
        else
        {
            _isSeeking = false;
        }
    }

    /// <summary>
    /// This function is called by the Unity engine and is used to draw gizmos in scene
    /// </summary>
    private void OnDrawGizmosSelected()
    {
        // Depending on the status, change the handles color
        if(_isSeeking)
        {
            Handles.color = new Color(1f, 0f, 0f, 0.1f);
        }
        else
        {
            Handles.color = new Color(0f, 1f, 0f, 0.1f);
        }
        // Draw a disc displaying the smell sense range for the zombie
        Handles.DrawSolidDisc(transform.position, Vector3.up, smellSense);
    }
}
