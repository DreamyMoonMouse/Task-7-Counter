using UnityEngine;

public class Display : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private View _view;

    private void OnEnable()
    {
        _counter.CountUpdated += _view.Update;
    }

    private void OnDisable()
    {
        _counter.CountUpdated -= _view.Update;
    }
}
