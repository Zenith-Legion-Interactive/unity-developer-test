using UnityEngine;
using UnityEngine.Events;

public class OnStartTriggerEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent _onUpdateEvent;

    private void Start()
    {
        _onUpdateEvent.Invoke();
    }
}

