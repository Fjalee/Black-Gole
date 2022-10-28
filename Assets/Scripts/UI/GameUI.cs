using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneLoader.Reload();
    }
}
