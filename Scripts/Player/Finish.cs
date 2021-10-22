using UnityEngine;

namespace Player
{
    public class Finish : MonoBehaviour
    {
        [SerializeField] private GameObject _profile; 
        public void Stop()
        {
            Time.timeScale = 0;
            _profile.gameObject.SetActive(true);
        }
    }
}