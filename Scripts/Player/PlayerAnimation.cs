using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private string _walkTansition;
   [SerializeField] private Rigidbody2D _rigidbody;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_rigidbody.velocity.x != 0)
        {
            Debug.Log("anim walk");
            _animator.SetBool(_walkTansition, true);
        }
        else
            _animator.SetBool(_walkTansition, false );
    }
}
