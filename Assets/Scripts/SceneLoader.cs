using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoader
{
    public enum Scene
    {
        Loading,
        Level1,
        Level2,
        Level3,
        MainMenu,
        LevelSelectorWindow,
        TutorialLoading,
        Tutorial,
        Credits
    }

    private static Action _onLoaderCallback;

    public static void LoadTutorial(Scene scene)
    {
        _onLoaderCallback = () =>
        {
            SceneManager.LoadScene(scene.ToString());
        };

        SceneManager.LoadScene(SceneLoader.Scene.TutorialLoading.ToString());
    }

    public static void LoadHeavy(Scene scene)
    {
        _onLoaderCallback = () =>
        {
            SceneManager.LoadScene(scene.ToString());
        };

        SceneManager.LoadScene(SceneLoader.Scene.Loading.ToString());
    }

    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public static void LoaderCallback()
    {
        if (_onLoaderCallback != null)
        {
            _onLoaderCallback();
            _onLoaderCallback = null;
        }
    }

    public static void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
