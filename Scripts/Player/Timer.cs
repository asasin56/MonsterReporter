using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _secondsField, _minutesField;
 [Range(0, 60)]   [SerializeField] private int _seconds, _minutes;
   [SerializeField] private Finish _finish;

    private void Start()
    {
        _secondsField.text = _seconds.ToString();
        _minutesField.text = _minutes.ToString();
        InvokeRepeating(nameof(UpdateTime), 1f , 1f );
    }

    public void UpdateTime()
    {
        _seconds --;
        if (_seconds < 0)
        {
            _seconds = 59;
            _minutes--;
            if (_minutes < 0)
                _finish.Stop();
          
            
        }  
        _minutesField.text = _minutes.ToString(); 
        _secondsField.text = _seconds.ToString(); 
    } 
}
