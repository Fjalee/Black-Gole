using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneLoader.LoadHeavy(SceneLoader.Scene.Level1); //temp change to level selection later
    }
}
