using UnityEngine;

namespace Player
{
    public  class Intersting : MonoBehaviour
    {
        [SerializeField] private int _cost;
        [SerializeField] private bool _isSecret;
        public int Cost => _cost;
        public bool IsSecret => _isSecret;
    }
}