using UnityEngine;
using UnityEngine.Events;

public class FloatVariableHandler : MonoBehaviour
{
    [SerializeField] private float _originalFloatValue;
    [SerializeField] private SOFloat _floatVariable;
    [SerializeField] private UnityEvent _onSetValueEvent;


    public void SetToOriginalValue()
    {
        _floatVariable.Value = _originalFloatValue;
        _onSetValueEvent.Invoke();
    }
}
