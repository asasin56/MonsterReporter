using System;
using InputHandler;
using UnityEngine;

namespace Player
{
    public class ReporterCamera : MonoBehaviour
    {
        [SerializeField] private Transform _centre; 
        [SerializeField] private KeyButton _key;
        [SerializeField] private KeyButton _outKey;
        [SerializeField] private float _radius;
        public event Action Using;
        
        private bool _isPlaying;
        [SerializeField] private Reportage _repotage;

        private void Start()
        {
            _key.Inputting += () =>
            { 
                _isPlaying = true;
            } ;
            _outKey.Inputting += () =>
            {
                _isPlaying = false; 
            };
        }

        private void FixedUpdate() => Play();

        public void Play()
        {
            if(!_isPlaying)
                return;
            Using?.Invoke();
            Collider2D collider = Physics2D.OverlapCircle(_centre.position, _radius);
            _repotage.AddMaterial(collider);
        }

    }
}