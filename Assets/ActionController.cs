using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionController : MonoBehaviour
{
    public UnityEvent action;
    public UnityEvent actionExit;

    void Start()
    {
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            action.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            actionExit.Invoke();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        action.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        actionExit.Invoke();
    }
}
