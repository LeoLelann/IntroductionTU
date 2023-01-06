using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Item
{

    [SerializeField] EntityGold _gold;
    private void OnTriggerEnter(Collider other)
    {
        _gold.AddGold(1);
        Destroy(gameObject);
    }
}
