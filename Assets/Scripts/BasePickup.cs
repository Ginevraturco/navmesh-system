using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePickup : MonoBehaviour
{
    protected GameObject _picker;

    public GameObject vfx;


    private void OnTriggerEnter(Collider other)
    {
        _picker = other.gameObject;

        Pickup();
    }

    protected virtual void Pickup()
    {
        if(vfx != null)
        {
            Instantiate(vfx, transform.position, transform.rotation);
        }

        gameObject.SetActive(false);
    }
}
