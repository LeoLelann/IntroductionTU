using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Codice.Client.BaseCommands.BranchExplorer.Layout.BrExLayout;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HitEntity : MonoBehaviour
{
    List<GameObject> _targets;

    private void Start()
    {
        _targets = new List<GameObject>();
    }
    public void AttackEntities(int attackPower)
    {
        foreach(GameObject target in _targets)
        {
            target.GetComponent<EntityHealth>().TakeDamage();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.transform.parent.gameObject.GetComponent<EntityHealth>() != null)
        {
            _targets.Add(other.transform.parent.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _targets.Remove(other.gameObject);
    }
}
