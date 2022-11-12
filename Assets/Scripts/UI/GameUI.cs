using UnityEngine;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    private Camera _cameraObserveLevel;

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
        _cameraObserveLevel.enabled = !_cameraObserveLevel.isActiveAndEnabled;
    }
}
