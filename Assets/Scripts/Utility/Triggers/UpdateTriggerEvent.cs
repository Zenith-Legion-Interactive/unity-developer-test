using UnityEngine;
using UnityEngine.Events;

public class UpdateTriggerEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent _onUpdateEvent;

    private void Update()
    {
        _onUpdateEvent.Invoke();
    }
}
