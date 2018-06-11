using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoad
{
    public static void LoadScene()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("UI", LoadSceneMode.Additive);
    }
}