using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Random = UnityEngine.Random;

public class RainSpawner : Dangerous
{
    [SerializeField] private List<RainedObject> _templates;

    [SerializeField] private PositionRandomaizer _randomaizer;
    [SerializeField] private Transform _fromPoint;
    [SerializeField] private float _cooldown;
    [SerializeField] private Transform _toPoint;
    [SerializeField] private int _count;
    [SerializeField] private bool _needRepeat;  
    private bool _isActive = false;
    private bool _isStarted;

    private void OnEnable() => StartCoroutine(CreateRain());

    public override void Init()
    {
        _isActive = true;
        if (!_isStarted)
        {
            StartCoroutine(CreateRain());
            _isStarted = true;
        }
    }

    private IEnumerator CreateRain()
    {
        if (!_isActive)
            yield break;
            
        Debug.Log("Start Corurine");

        
        for (int i = 0; i < _count; i++)
        {
            Debug.Log(i + "object spawned");
            GameObject rainedObject = Instantiate(_templates[Random.Range(0, _templates.Count)]).gameObject;
            rainedObject.transform.position = _randomaizer.CountPosition(_fromPoint, _toPoint);
        }

        yield return new WaitForSeconds(_cooldown);
        if(_needRepeat)
            StartCoroutine(CreateRain());
    }

    public override void Finish()
    {
        _isActive = false;
        _isStarted = false;

    }

}