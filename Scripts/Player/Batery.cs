using System;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    [RequireComponent(typeof(ReporterCamera))]
    public class Batery : MonoBehaviour
    {
        [SerializeField] private Image _previerw; 
        private float _percents = 1f;
        private ReporterCamera _reporterCamera;
        [SerializeField] private Finish _finish;

        private void Start()
        {
            _reporterCamera = GetComponent<ReporterCamera>();

            _reporterCamera.Using += () =>
            {
                if (_percents < 1)
                    _finish.Stop();
                
                _percents--;
                _previerw.fillAmount = _percents; 
            };
        } 
    }
}
