using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public class EarthShaking : Dangerous
{
    [SerializeField] private Animator _cameraShaking;
    [SerializeField] private string _shakeParameter; 
    [SerializeField] private Rigidbody2D _player;
    [SerializeField] private float _time;
    private bool _isShake;
    [SerializeField] private Finish _finish;

    public override void Init()
    {
        Debug.Log("VAR");
        _isShake = true;
        Invoke(nameof(Finish),_time );
    //    _cameraShaking.SetBool(_shakeParameter, true);
    }

    private void FixedUpdate()
    {
        if (_isShake && _player.velocity.x != 0)
        {
            _finish.Stop(); 
        }
    }

    public override void Finish()
    {
    //    _cameraShaking.SetBool(_shakeParameter, false);
        _isShake = false; 
    }
}
