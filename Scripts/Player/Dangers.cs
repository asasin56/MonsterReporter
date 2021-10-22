using UnityEngine;

public class Dangers : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D  other)
    {
        if (other.TryGetComponent(out RainSpawner spawner))
        {
            spawner.Init();
            Debug.Log("SPAWN");
        }
    }
    
    private void OnTriggerExit2D(Collider2D  other)
    {
        if (other.TryGetComponent(out RainSpawner spawner)) spawner.Finish();
        
    }

}