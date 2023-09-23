
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    protected static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                var objs = FindObjectsOfType(typeof(T)) as T[];
                if (objs.Length > 0)
                    instance = objs[0];
                if (objs.Length > 1)
                {
                    Debug.LogError("More than one singleton instance of " + instance.gameObject.name);
                    Destroy(objs[1].gameObject);
                }
            }
            return instance;
        }

        set
        {
            instance = value;
        }
    }

    private void OnEnable()
    {
        if (instance != this && instance != null)
        {
            Destroy(gameObject);
        }
    }

    public void UnsetSingleton()
    {
        Destroy(Instance);
        Instance = null;
    }

    public void OnDestroy()
    {
        if (instance != null)
        {
            instance = null;
        }
    }
}