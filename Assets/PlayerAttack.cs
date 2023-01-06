using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] InputActionReference _attack;

    public event Action OnAttack;

    void Start()
    {
        _attack.action.started += OnPlayerAttack; 
    }

    private void OnPlayerAttack(InputAction.CallbackContext obj)
    {
        OnAttack?.Invoke();
    }

    void Update()
    {
        
    }
}
