using System.Collections;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    private Camera _cameraObserveLevel;

    [SerializeField]
    private int _secondsToObserveLevelAtStart = 2;

    private IEnumerator ObserveLevelForTime(int secondsToWait)
    {
        _cameraObserveLevel.enabled = true;
        yield return new WaitForSeconds(secondsToWait);
        _cameraObserveLevel.enabled = false;
    }

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
