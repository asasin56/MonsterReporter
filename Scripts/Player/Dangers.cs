using System;
using Player;
using UnityEngine;

public class Dangers : MonoBehaviour
{
    [SerializeField] private Finish _finish;

    private void OnTriggerEnter2D(Collider2D  other)
    {
        if (other.TryGetComponent(out Dangerous spawner)) spawner.Init();
    }
    
    private void OnTriggerExit2D(Collider2D  other)
    {
        if (other.TryGetComponent(out Dangerous spawner)) spawner.Finish();
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.TryGetComponent<RainedObject>(out RainedObject rainedObject) && !other.collider.isTrigger)
            _finish.Stop();
    }
}
