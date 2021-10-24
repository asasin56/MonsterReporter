using System;
using System.Security.Cryptography;
using UnityEngine;

class RainedObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent(out Floor floor)) 
            Destroy(gameObject);
        
    }
}