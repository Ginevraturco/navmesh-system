using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDestroyerPickup : BasePickup
{
    public GameObject zombieDeathVfx;
    protected override void Pickup()
    {
        var zombies = GameObject.FindObjectsOfType<ZombieController>();
        foreach(var zombie in zombies)
        {
            if(zombieDeathVfx != null)
            {
                Instantiate(zombieDeathVfx,
                            zombie.transform.position,
                            zombie.transform.rotation);
            }
            Destroy(zombie.gameObject);
        }

        base.Pickup();
    }
}
