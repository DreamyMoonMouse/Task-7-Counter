using TMPro;
using UnityEngine;

public class Display : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.CountUpdated += UpdateDisplay; 
    }

    private void OnDisable()
    {
        _counter.CountUpdated -= UpdateDisplay; 
    }

    private void UpdateDisplay(int newCount)
    {
        _text.text = newCount.ToString();
    }
}
