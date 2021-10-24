using System;
using InputHandler;
using UnityEngine;

namespace Player
{
    public class ReporterCamera : MonoBehaviour
    {
        [SerializeField] private KeyButton _key;
        [SerializeField] private KeyButton _outKey;
        [SerializeField] private GameObject _cameraUI; 
        public event Action Using;
        
        private bool _isPlaying;
        [SerializeField] private Reportage _repotage;
        public event Action StopUsing; 

        private void Start()
        {
            _key.Inputting += () =>
            { 
                _isPlaying = true;
                _cameraUI.SetActive(true);
                Using?.Invoke();
            } ;
            _outKey.Inputting += () =>
            {
                _isPlaying = false; 
                _cameraUI.SetActive(false);
                StopUsing?.Invoke();
            };
        }
        

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Intersting intersting) && _isPlaying)
            {
                _repotage.AddMaterial(intersting);
            }
        }


    }
    
}