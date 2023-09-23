using TMPro;
using UnityEngine;

public class TextValueToggle : MonoBehaviour
{
    [SerializeField] private string _initialValue;
    [SerializeField] private string _toggleValue;
    [SerializeField] private TMP_Text _targetText;

    private void Awake()
    {
        _targetText.text = _initialValue;
    }

    public void Toggle()
    {
        if (_targetText.text == _initialValue)
        {
            _targetText.text = _toggleValue;
        }
        else
        {
            _targetText.text = _initialValue;
        }
    }
}
