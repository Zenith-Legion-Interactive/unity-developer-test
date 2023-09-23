using UnityEngine;
using UnityEngine.Events;
using Cysharp.Threading.Tasks;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private UnityEvent _startGameOver;
    [SerializeField] private UnityEvent _triggerGameOver;

    private async void OnTriggerEnter(Collider other)
    {
        await Darkener.Instance.FadeOut(2, 0.015f, 1);
        _startGameOver.Invoke();
        await Darkener.Instance.FadeIn(2, 0.015f, 0);
        _triggerGameOver.Invoke();
    }
}
