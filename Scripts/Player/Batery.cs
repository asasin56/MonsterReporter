using System;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    [RequireComponent(typeof(ReporterCamera))]
    public class Batery : MonoBehaviour
    {
        [SerializeField] private Image _previerw; 
        [SerializeField] private float _volts = 5000f;
        private float _currentVolts;  
        private ReporterCamera _reporterCamera;
        [SerializeField] private Finish _finish;
        private bool _isActive;

        private void Start()
        {
            _reporterCamera = GetComponent<ReporterCamera>();
            _currentVolts = _volts;
            InvokeRepeating(nameof(UpdateBatery), 1f, 1f);
            _reporterCamera.Using += () => _isActive = true; 
                _reporterCamera.StopUsing += () => _isActive = false; 
        }
        public void UpdateBatery()
        {
            if (!_isActive)
                return;
            if (_currentVolts < 1)
                  _finish.Stop();
            _currentVolts--;
            _previerw.fillAmount = _currentVolts / _volts; 
        }

    }
}
