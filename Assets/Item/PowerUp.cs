using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Item
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
