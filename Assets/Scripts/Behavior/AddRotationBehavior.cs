using UnityEngine;
using UnityEngine.Events;

public class AddRotationBehavior : MonoBehaviour
{
    [SerializeField] private SOFloat _rotationSpeed;
    [SerializeField] private UnityEvent _onAddRotationSpeedEvent;

    private void OnMouseDown()
    {
        AddRotationSpeed();
    }

    public void AddRotationSpeed()
    {
        _rotationSpeed.Value += _rotationSpeed.Value;
        _onAddRotationSpeedEvent.Invoke();
    }
}
