using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TMPro;
using UnityEngine;

namespace Player
{
    public class Reportage  : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _moneyField;
        private float _earnedMoney;
        private List<Intersting> _interstings = new List<Intersting>(15);
        

        public void AddMaterial(Intersting intersting)
        {
            foreach (var interset in _interstings)
            {
                if (intersting == interset) 
                    return;
            }
            _interstings.Add(intersting);
            _earnedMoney += intersting.Cost;
            DisplayMoney();
        }

         private void DisplayMoney() => _moneyField.text = _earnedMoney.ToString(CultureInfo.InvariantCulture);
    }
}