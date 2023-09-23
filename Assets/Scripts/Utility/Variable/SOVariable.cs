using UnityEngine;
using UnityEngine.Events;

public abstract class SOVariable<T> : ScriptableObject
{
    [SerializeField] protected T value;
    
    [SerializeField, TextArea] private string variableNote;

    [SerializeField] private UnityEvent OnVariableUpdate;
    [SerializeField] private UnityEvent OnVariableReset;

    public T Value
    {
        get => value;
        set
        {
            this.value = value;
            OnVariableUpdate.Invoke();
        }
    }

    [ContextMenu("ResetValue")]
    public virtual void ResetValue()
    {
        value = default(T);
        OnVariableReset.Invoke();
    }
}