using System;
using System.Security.Cryptography;
using UnityEngine;

class RainedObject : MonoBehaviour
{
        [SerializeField] private  ParticleSystem _explosion; 
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent(out Floor floor))
        {
           ParticleSystem boom = Instantiate(_explosion);
           boom.transform.position = transform.position;
           // Destroy(boom, 5f);
            Destroy(gameObject);
        }

    }
}