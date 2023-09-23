using UnityEngine;

public class PhysicsResetBehavior : MonoBehaviour
{
    [SerializeField] private SOBallPhysics _ballInstance;

    public void ResetBall()
    {
        _ballInstance.Value.RollForward();
    }
}
