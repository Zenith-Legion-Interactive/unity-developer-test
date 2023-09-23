using UnityEngine;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _textObject;

    public void SetTextValue(SOFloat floatVariable)
    {
        _textObject.text = floatVariable.Value.ToString();
    }
    public void SetTextValue(SOInteger integerVariable)
    {
        _textObject.text = integerVariable.Value.ToString();
    }

    public void SetTextValue(SOVector3 vector3Variable)
    {
        _textObject.text = vector3Variable.Value.ToString();
    }
}

