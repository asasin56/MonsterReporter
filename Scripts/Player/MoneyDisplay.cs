using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyDisplay : MonoBehaviour
{ 
    [SerializeField] private  TextMeshProUGUI _moneyView;
    [SerializeField] private Purse _purse; 
    private void OnEnable()
    {
        _moneyView.text = _purse.Coins.ToString();
    }
}
