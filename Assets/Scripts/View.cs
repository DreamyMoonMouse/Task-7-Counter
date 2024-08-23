using TMPro;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void Update(int newValue)
    {
        _text.text = newValue.ToString();
    }
}