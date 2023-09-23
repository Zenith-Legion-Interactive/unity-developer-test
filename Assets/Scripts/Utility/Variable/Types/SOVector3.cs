
using UnityEngine;

[CreateAssetMenu(fileName = "New Vector3 Variable", menuName = "Variable/Vector3")]
public class SOVector3 : SOVariable<Vector3>
{
    public override void ResetValue()
    {
        value = Vector3.zero;
    }
}
