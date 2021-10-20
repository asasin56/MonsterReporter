using UnityEngine;

namespace Player
{
    public class Reportage  : MonoBehaviour
    {
        private float _earnedMoney;

        public void AddMaterial(Collider2D collider)
        {
            if(!collider.TryGetComponent(out Intersting intersting))
                return;
            _earnedMoney += intersting.Cost; 

        }
    }
}