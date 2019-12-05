using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinPowerup : BasePickup
{
    protected override void Pickup()
    {
        var vc = _picker.GetComponent<VampireController>();
        if (vc == null) return;
        vc.Powerup();


        base.Pickup();
    }
}
