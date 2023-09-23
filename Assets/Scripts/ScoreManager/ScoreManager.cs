using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private SOInteger _scoreVariable;

    private float _currentTime;

    private void Start()
    {
        _currentTime = 0;
        _scoreVariable.Value = 0;
    }



    public void ProcessScore()
    {
        _currentTime += Time.deltaTime;
        _scoreVariable.Value = (int)_currentTime;
    }
}
