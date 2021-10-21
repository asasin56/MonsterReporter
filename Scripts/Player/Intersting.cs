using UnityEngine;

namespace Player
{
    public  class Intersting : MonoBehaviour
    {
        [SerializeField] private int _cost; 
        public int Cost => _cost;
    }
}