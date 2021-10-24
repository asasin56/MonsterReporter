using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class GhostMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D _rigidbody;

    private void Start() => _rigidbody = GetComponent<Rigidbody2D>();

    private void Update()
    {
        _rigidbody.velocity = new Vector2(_speed, 0);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Finish finish) && other.GetComponent<Rigidbody2D>().velocity.x != 0 )
        {
            finish.Stop();
        }

        if (other.TryGetComponent(out GhostDeleter deleter))
        {
            Destroy(gameObject);
        }
    }
}

