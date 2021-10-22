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
        private List<Intersting> _interstings = new List<Intersting>(15);
        

        public void AddMaterial(Intersting intersting)
        {
            foreach (var interset in _interstings)
            {
                if (intersting == interset) 
                    return;
            }
            _interstings.Add(intersting);
            _purse.Coins += intersting.Cost;
            DisplayMoney();
        }

         private void DisplayMoney() => _moneyField.text = _purse.Coins.ToString(CultureInfo.InvariantCulture);
    }
}