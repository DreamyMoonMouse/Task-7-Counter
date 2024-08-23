using UnityEngine;
using System.Collections;
using System;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _deley = 0.5f;
    
    public event Action<int> CountUpdated;
    
    private int _value = 0;
    private bool _isRunning = false;  
    private Coroutine _counterCoroutine;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isRunning)
            {
                StopCoroutine(_counterCoroutine);
                _isRunning = false;
            }
            else
            {
                _isRunning = true;
                _counterCoroutine = StartCoroutine(Increment());
            }
        }
    }

    private IEnumerator Increment()
    {
        var wait = new WaitForSeconds(_deley);

        while (_isRunning)
        {
            _value++;
            CountUpdated?.Invoke(_value);

            yield return wait;
        }
    }
}
