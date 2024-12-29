using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{

    public override void Die()
    {
        Debug.Log(this.gameObject.name + " öldü");
    }
}
