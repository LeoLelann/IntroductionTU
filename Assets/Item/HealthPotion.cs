using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Item
{
    [SerializeField] EntityHealth _heal;
    [SerializeField] int healthgain;
    private void OnTriggerEnter(Collider other)
    {
        _heal.AddHealth(healthgain);
        Destroy(gameObject);
    }


}
