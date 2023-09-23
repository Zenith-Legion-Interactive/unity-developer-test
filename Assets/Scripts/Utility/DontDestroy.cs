using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        transform.SetParent(null);
        DontDestroyOnLoad(this);
    }
}
