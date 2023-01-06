using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;

    public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    public void AddHealth(int healthgain)
    {
        CurrentHealth += healthgain;

        if(CurrentHealth > _maxHealth)
        {
            CurrentHealth = _maxHealth;
        }
    }

}
