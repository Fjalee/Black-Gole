using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void SelectLevel()
    {
        SceneLoader.Load(SceneLoader.Scene.LevelSelectorWindow);
    }
}
