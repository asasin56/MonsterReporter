using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GhostPositionRandomizer : PositionRandomaizer
{
   [SerializeField] private Transform _player;
   [SerializeField] private float _height;
   [SerializeField]  private float _lenght;

   public override Vector3 CountPosition(Transform from, Transform to)
   {
      Vector3 position = new Vector3(_player.position.x + _lenght , _height);
      return  position;
   } 
}
