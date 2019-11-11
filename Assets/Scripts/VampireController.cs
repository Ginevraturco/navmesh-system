using UnityEngine;
using UnityEngine.AI;

public class VampireController : MonoBehaviour
{
    private NavMeshAgent _agent;

    public GameObject targetPoint;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            var hasHit = Physics.Raycast(ray, out hit, 100);
            if(hasHit)
            {
                _agent.destination = hit.point;
                targetPoint.transform.position = hit.point;
            }

        }


    }
}
