using UnityEngine;

public class Dangers : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D  other)
    {
        if (other.TryGetComponent(out Dangerous spawner)) spawner.Init();
    }
    
    private void OnTriggerExit2D(Collider2D  other)
    {
        if (other.TryGetComponent(out Dangerous spawner)) spawner.Finish();
        
    }

}