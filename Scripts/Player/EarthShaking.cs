using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public class EarthShaking : Dangerous
{
    [SerializeField] private ParticleSystem _shakeParticles; 
    [SerializeField] private Animator _cameraShaking;
    [SerializeField] private string _shakeParameter; 
    [SerializeField] private Rigidbody2D _player;
    [SerializeField] private float _time;
    private bool _isShake;
    [SerializeField] private Finish _finish;

    public override void Init()
    { 
        _isShake = true;
        Invoke(nameof(Finish),_time );
        _cameraShaking.SetBool(_shakeParameter, true);
        _shakeParticles.Play();
    }

    private void FixedUpdate()
    {
        if (_isShake && Mathf.Abs(_player.velocity.x) > 8 ) _finish.Stop();
    }

    public override void Finish()
    {
        _shakeParticles.Stop();
        _cameraShaking.SetBool(_shakeParameter, false);
        _isShake = false; 
    }
}
