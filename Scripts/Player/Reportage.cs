using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TMPro;
using UnityEngine;

namespace Player
{
    public class Reportage  : MonoBehaviour
    {
        [SerializeField] private Purse _purse; 
        [SerializeField] private TextMeshProUGUI _moneyField;
        [SerializeField] private TextMeshProUGUI _secretsField;
        private List<Intersting> _interstings = new List<Intersting>(15);
        private float _earnedMoney;
        private float _secrets;
        [SerializeField] private TextMeshProUGUI _likesField;
        private float _likes;

        public void AddMaterial(Intersting intersting)
        {
            foreach (var interset in _interstings)
            {
                if (intersting == interset) 
                    return;
            }
            _interstings.Add(intersting);
            if (intersting.IsSecret)
                _secrets++; 
            _purse.Coins += intersting.Cost;
            _earnedMoney += intersting.Cost;
            _likes = Mathf.Round(Mathf.Pow(_earnedMoney , 2) + Random.Range(0, Mathf.Sqrt(_earnedMoney)) * Random.Range(0,2)) ; 
            DisplayMoney();
        }

        private void DisplayMoney()
        {
            _secretsField.text = _secrets.ToString(CultureInfo.InvariantCulture); 
            _likesField.text = _likes.ToString(CultureInfo.InvariantCulture);
        _moneyField.text = _earnedMoney.ToString(CultureInfo.InvariantCulture);
        }

    }
}