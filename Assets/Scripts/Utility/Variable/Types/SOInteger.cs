using UnityEngine;

    [CreateAssetMenu(menuName = "Variable/Integer")]
public class SOInteger : SOVariable<int>
{
    public override void ResetValue()
    {
        value = 0;
    }
}
