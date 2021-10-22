using System;
using UnityEditor;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private string horizontalAxis;
        private Rigidbody2D _rigidbody;

        private void Start() => _rigidbody = GetComponent<Rigidbody2D>(); 

        private void Update()
        {
            float horizontal = Input.GetAxis(horizontalAxis);
            _rigidbody.velocity = new Vector2(_speed * horizontal,_rigidbody.velocity.y );
            if (_rigidbody.velocity.x != 0)
                transform.eulerAngles = _rigidbody.velocity.x > 0 ? new Vector3(0,0,0) : new Vector3(0,180, 0);
        }
    }
}
