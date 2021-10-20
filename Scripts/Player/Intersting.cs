using UnityEngine;

namespace Player
{
    public abstract class Intersting
    {
        [SerializeField] private int _cost; 
        public int Cost => _cost;
    }
}