using UnityEngine;

[CreateAssetMenu(fileName = "New Float Variable", menuName = "Variable/Float")]
public class SOFloat : SOVariable<float>
{
    public override void ResetValue()
    {
        value = 0;
    }
}
