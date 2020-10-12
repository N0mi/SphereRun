using UnityEngine.SceneManagement;

public static class SceneReloader
{
    public static void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

