using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void SelectLevel()
    {
        SceneLoader.Load(SceneLoader.Scene.LevelSelectorWindow);
    }

    public void SelectCredits()
    {
        SceneLoader.Load(SceneLoader.Scene.Credits);
    }
}
