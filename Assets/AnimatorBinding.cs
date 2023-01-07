using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputSettings;

public class AnimatorBinding : MonoBehaviour
{
    [SerializeField] PlayerMove _playerMove;
    [SerializeField] PlayerAttack _playerAttack;
    [SerializeField] EntityHealth _entityHealth;
    [SerializeField] Animator _animator;

    void Start()
    {
        //Inscription aux événements de PlayerMove
        _playerMove.OnStartMove += OnStartMove;
        _playerMove.OnStopMove += OnStopMove;

        //Inscription aux événements de PlayerAttack
        _playerAttack.OnAttack += OnPlayerAttack;

        //Inscription aux événements de EntityHealth
        _entityHealth.OnHit += OnPlayerHit; ;
    }

    private void OnPlayerHit()
    {
        _animator.SetTrigger("GetHit");
    }

    private void OnPlayerAttack()
    {
        _animator.SetTrigger("Attack");
    }

    void OnDestroy()
    {
        _playerMove.OnStartMove -= OnStartMove;
        _playerMove.OnStopMove -= OnStopMove;

        _playerAttack.OnAttack -= OnPlayerAttack;
    }

    private void OnStopMove()
    {
        _animator.SetBool("Walking", false);
    }

    private void OnStartMove()
    {
        _animator.SetBool("Walking", true);
    }

    void Update()
    {
        
    }
}
