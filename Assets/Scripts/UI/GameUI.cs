using UnityEngine;

public class GameUI : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneLoader.Reload();
    }

    public void BackToMenu()
    {
        SceneLoader.Load(SceneLoader.Scene.MainMenu);
    }

    public void ObserveLevel()
    {

    }
}
