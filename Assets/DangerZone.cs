using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    [SerializeField] int _damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<EntityHealth>() != null)
        {
            EntityHealth health = other.GetComponentInParent<EntityHealth>();
            health.TakeDamage(_damage);
            if (health.CurrentHealth == 0)
            {
                Destroy(health.gameObject);
            }
        }
    }
}
