using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void SelectLevel()
    {
        SceneLoader.Load(SceneLoader.Scene.LevelSelectorWindow);
    }

    public void SelectTutorial()
    {
        SceneLoader.LoadTutorial(SceneLoader.Scene.Tutorial);
    }

    public void SelectCredits()
    {
        SceneLoader.Load(SceneLoader.Scene.Credits);
    }

    public void SelectQuit()
    {
        Application.Quit();
    }
}
