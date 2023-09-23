using UnityEngine;
using UnityEngine.Events;

public class BallPhysicsBehavior : MonoBehaviour
{
    [SerializeField] private SOBallPhysics _instance;
    [SerializeField] private SOVector3 _velocity;
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _force = 10f;
    [SerializeField] private UnityEvent _onBounceEvent;

    private Vector3 _initialPosition;

    private void Awake()
    {
        _instance.Value = this;
        _initialPosition = transform.position;
    }

    private void OnDestroy()
    {
        _instance.Value = null; 
    }

    public void RollForward()
    {
        transform.position = _initialPosition;
        _rigidBody.velocity = Vector3.zero;
        _rigidBody.AddForce(Vector3.forward * _force, ForceMode.Impulse);
    }

    public void RecordPhysicsVelocity()
    {
        _velocity.Value = _rigidBody.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        _onBounceEvent.Invoke();
    }
}


