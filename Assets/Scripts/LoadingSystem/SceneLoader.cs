using UnityEngine;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

[CreateAssetMenu()]
public class SceneLoader : ScriptableObject
{
    public async void LoadScene(string sceneName)
    {
        await Darkener.Instance.FadeOut();
        await SceneManager.LoadSceneAsync(sceneName);
        await Darkener.Instance.FadeIn();
    }
}
