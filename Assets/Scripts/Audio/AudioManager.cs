using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixer _mainAudioMixer;

    private bool _isBGMOn, _isUIOn;

    private void Awake()
    {
        _mainAudioMixer.SetFloat("UI", 0);
        _mainAudioMixer.SetFloat("BGM", -12);
        _isBGMOn = true;
        _isUIOn = true;
    }

    public void ToggleBGM()
    {
        if (_isBGMOn)
        {
            _mainAudioMixer.SetFloat("BGM", -80);
        }

        else
        {
            _mainAudioMixer.SetFloat("BGM", -12);
        }

        _isBGMOn = !_isBGMOn;
    }

    public void ToggleUI()
    {
        if (_isUIOn)
        {
            _mainAudioMixer.SetFloat("UI", -80);
        }
        else
        {
            _mainAudioMixer.SetFloat("UI", 0);
        }

        _isUIOn = !_isUIOn;
    }
}
