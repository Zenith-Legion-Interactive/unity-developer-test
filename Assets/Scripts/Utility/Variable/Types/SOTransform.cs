using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/Transform")]
public class SOTransform : SOVariable<Transform>
{
    public override void ResetValue()
    {
        value = null;
    }
}
