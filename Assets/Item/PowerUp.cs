using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Item
{
    [SerializeField] EntityHealth _powerUp;
    [SerializeField] int maxHealthGain;

    private void OnTriggerEnter(Collider other)
    {
        _powerUp.ActivePowerUp(maxHealthGain);
        Destroy(gameObject);
    }

}
