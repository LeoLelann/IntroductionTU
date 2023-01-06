using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityGold : MonoBehaviour
{
    [SerializeField] int goldcount;
    [SerializeField] GoldUI _gold;

    private void Awake()
    {
        goldcount = 0;
    }

    public void AddGold(int gold)
    {
        goldcount += gold;
        _gold.GoldUpdate(goldcount);
    }
}
