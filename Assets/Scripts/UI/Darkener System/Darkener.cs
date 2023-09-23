using UnityEngine;
using Cysharp.Threading.Tasks;
using UnityEngine.UI;

public class Darkener : Singleton<Darkener>
{
    [SerializeField] Image _fillImage;

    private bool _isFading;

    public async UniTask FadeOut(float speed = 2, float fillStrength = 0.015f, float normalizedMaxValue = 1)
    {
        if (_isFading) return;

        _isFading = true;
        Color newSetColor = _fillImage.color;
        newSetColor.a = 0;
        _fillImage.color = newSetColor;

        while (_fillImage.color.a < normalizedMaxValue)
        {
            newSetColor.a += fillStrength;
            _fillImage.color = newSetColor;
            await UniTask.Delay(((int)(1 / speed)) * 100);
        }

        newSetColor.a = 1;
        _fillImage.color = newSetColor;
        _isFading = false;
    }

    public async UniTask FadeIn(float speed = 2, float fillStrength = 0.015f, float NormalizedMinValue = 0)
    {
        if (_isFading) return;

        _isFading = true;
        Color newSetColor = _fillImage.color;
        newSetColor.a = 1;
        _fillImage.color = newSetColor;

        while (_fillImage.color.a > NormalizedMinValue)
        {
            newSetColor.a -= fillStrength;
            _fillImage.color = newSetColor;
            await UniTask.Delay(((int)(1 / speed)) * 100);
        }

        newSetColor.a = 0;
        _fillImage.color = newSetColor;
        _isFading = false;
    }
}
