using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using UnityEngine.Events;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;

    [SerializeField] HealthUI _healthUI;

    [SerializeField] PowerUp powerUp;

    public event Action OnHit;

    [SerializeField] UnityEvent _onHeal;
    [SerializeField] UnityEvent _onDamage;

    public int CurrentHealth { get; private set; }
    public int MaxHealth { get => _maxHealth; set => _maxHealth = value; }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    private void Start()
    {
        _healthUI?.MaxHealthUpdate(_maxHealth);
        _healthUI?.UpdateSlider(CurrentHealth);
    }

    public void AddHealth(int healthgain)
    {
        _onHeal.Invoke();
        CurrentHealth += healthgain;

        if(CurrentHealth > _maxHealth)
        {
            CurrentHealth = _maxHealth;
        }
        _healthUI?.UpdateSlider(CurrentHealth);
    }

    public void ActivePowerUp(int maxHealthGain)
    {
        _maxHealth += maxHealthGain;
        _healthUI?.MaxHealthUpdate(_maxHealth);
        _healthUI?.UpdateSlider(CurrentHealth);
    }

    public void TakeDamage(int damage)
    {
        _onDamage.Invoke();
        OnHit?.Invoke();
        CurrentHealth -= damage;
        _healthUI?.UpdateSlider(CurrentHealth);
    }
}
