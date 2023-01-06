using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GoldUI : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _text;

    public void GoldUpdate(int goldValue)
    {
        _text.text = $"Gold: {goldValue}";
    }
}
