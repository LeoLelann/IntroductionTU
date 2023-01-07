using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Codice.Client.BaseCommands.BranchExplorer.Layout.BrExLayout;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HitEntity : MonoBehaviour
{
    List<EntityHealth> _targets;
    [SerializeField] BoxCollider _collider;

    public List<EntityHealth> Targets { get => _targets; }

    private void Start()
    {
        _targets = new List<EntityHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<EntityHealth>() != null)
        {
            _targets.Add(other.GetComponentInParent<EntityHealth>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _targets.Remove(other.GetComponentInParent<EntityHealth>());
    }

    public void RemoveTarget(EntityHealth health)
    {
        _targets.Remove(health);
    }
}
