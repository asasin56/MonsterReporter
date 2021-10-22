using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MetiorMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D _rigidbody;
    private float _speedX; 
    private void Start()
    {  
        var distance = Vector2.Distance(
                 new Vector2(FindObjectOfType<PlayerMovement>().transform.position.x, 0), new Vector2(transform.position.x, 0));
        _speedX =  FindObjectOfType<PlayerMovement>().transform.position.x < transform.position.x ? -distance :  distance;
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() => _rigidbody.velocity = new Vector2(_speedX , _speed);
}
