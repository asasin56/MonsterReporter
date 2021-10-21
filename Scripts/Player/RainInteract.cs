using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public class RainInteract : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Finish finish))
        {
            finish.Stop();
        }

        if (!other.isTrigger)
        {
            Destroy(gameObject);
        }
    }
}
