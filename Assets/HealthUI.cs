using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    [SerializeField] Slider _slider;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] EntityHealth _playerHealth;
    public int CachedMaxHealth { get; set; }

    public void MaxHealthUpdate(int _maxHealth)
    {
        CachedMaxHealth = _playerHealth.MaxHealth;
    }

    public void UpdateSlider(int newHealthValue)
    {
        _slider.value = newHealthValue;
        _text.text = $"{newHealthValue} / {CachedMaxHealth}";
    }



}
