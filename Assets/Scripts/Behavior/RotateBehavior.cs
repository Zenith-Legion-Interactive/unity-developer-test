using UnityEngine;
using UnityEngine.Events;

public class RotateBehavior : MonoBehaviour
{
    //been using the SO workfow since 2017 where it is applicable
    [SerializeField] private SOFloat _rotateSpeed;
    [SerializeField] private float _defaultRotationSpeed = 100f;
    [SerializeField] private UnityEvent _onSetInitialRotateSpeed;

    private void Awake()
    {
        _rotateSpeed.Value = _defaultRotationSpeed;
        _onSetInitialRotateSpeed.Invoke();
    }

    private void OnDestroy()
    {
        _rotateSpeed.ResetValue();
    }

    public void RotateY()
    {
        // rotates the the transform around the Y axis multiplied by delta time in order to make it frame rate independent 
        transform.Rotate(new Vector3(0, _rotateSpeed.Value * Time.deltaTime, 0));
    }
}
