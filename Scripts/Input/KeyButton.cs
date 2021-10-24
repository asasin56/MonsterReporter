using System;
using UnityEngine;

namespace InputHandler

{
    public abstract class KeyButton : MonoBehaviour
    {
        [SerializeField] private KeyCode _key; 
        public virtual event Action Inputting;

        public void Update()
        {
            if (Input.GetKeyDown(_key) && Time.timeScale > 0)
            {
                Inputting?.Invoke(); 
            }
        } 
    }
}
