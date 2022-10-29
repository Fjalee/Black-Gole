using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneLoader.LoadHeavy(SceneLoader.Scene.LevelSelectorWindow);
    }
}
