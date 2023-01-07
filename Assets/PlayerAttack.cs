using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] InputActionReference _attack;
    [SerializeField] HitEntity _attackZone;
    [SerializeField] int _attackPower;
    [SerializeField] UnityEvent _onPlayerAttack;

    public event Action OnAttack;
    Coroutine AttackingRoutine { get; set; }

    void Start()
    {
        _attack.action.started += OnPlayerAttack;
    }

    private void OnDestroy()
    {
        _attack.action.started -= OnPlayerAttack;
    }

    private void OnPlayerAttack(InputAction.CallbackContext obj)
    {
        StartCoroutine(AttackRoutine());
    }

    IEnumerator AttackRoutine()
    {
        OnAttack?.Invoke();
        _onPlayerAttack.Invoke();
        for (int i = 0; i < _attackZone.Targets.Count; i++)
        {
            EntityHealth health = _attackZone.Targets[i];
            health.TakeDamage(_attackPower);
            if (health.CurrentHealth == 0)
            {
                _attackZone.RemoveTarget(health);
                Destroy(health.gameObject);
            }
        }
        yield return new WaitForSeconds(2f);
    }

}
