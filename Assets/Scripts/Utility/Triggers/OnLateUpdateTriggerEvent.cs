using UnityEngine;
using UnityEngine.Events;

public class OnLateUpdateTriggerEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent _onLateUpdateEvent;

    private void LateUpdate()
    {
        _onLateUpdateEvent.Invoke();
    }
}
