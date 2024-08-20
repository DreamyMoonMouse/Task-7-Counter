using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _deley = 0.5f;
    
    private int _count = 0;  
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
                _counterCoroutine = StartCoroutine(IncrementCounter());
            }
        }
    }
    
    private IEnumerator IncrementCounter()
    {
        var wait = new WaitForSeconds(_deley);
        
        while (_isRunning)
        {
            _count++;
            _text.text = _count.ToString();

            yield return wait;
        }
    }
}
