using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;

    [SerializeField] HealthUI _healthUI;

    [SerializeField] PowerUp powerUp;

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
        _healthUI.UpdateSlider(CurrentHealth);
    }

    public void ActivePowerUp(int maxHealthGain)
    {
        _maxHealth += maxHealthGain;
        _healthUI.UpdateSlider(_maxHealth);
    }

    public void TakeDamage()
    {
        Debug.Log("DAMAGE");
    }
}
