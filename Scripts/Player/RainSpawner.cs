using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Random = UnityEngine.Random;

public class RainSpawner : MonoBehaviour
{
    [SerializeField] private List<RainedObject> _templates;

    [SerializeField] private PositionRandomaizer _randomaizer;
    [SerializeField] private float _fromPoint;
    [SerializeField] private float _cooldown;
    [SerializeField] private float _toPoint;
    [SerializeField] private int _count;
    private bool _isActive = false;

    private void OnEnable() => StartCoroutine(CreateRain());

    public void Init()
    {
        _isActive = true;
    }

    private IEnumerator CreateRain()
    {
        if (_isActive)
            yield break;
            
        Debug.Log("Start Corurine");

        yield return new WaitForSeconds(_cooldown);
        
        for (int i = 0; i < _count; i++)
        {
            Debug.Log(i + " object spawned");
            GameObject rainedObject = Instantiate(_templates[Random.Range(0, _templates.Count)]).gameObject;
            rainedObject.transform.position = _randomaizer.CountPosition(_fromPoint, _toPoint);
        }

        StartCoroutine(CreateRain());


    }

    public void Finish()
    {
        _isActive = false;
    }

}