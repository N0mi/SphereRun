using UnityEngine.SceneManagement;

public static class SceneReloader
{
    public static void ReloadScene()
    {
        ScoreManager.Score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

