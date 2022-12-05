using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionHandle : MonoBehaviour
{
    [SerializeField]
    List<int> _disabledButtonsIndexFromZero = new List<int>();
    [SerializeField]
    List<int> _hideButtonsIndexFromZero = new List<int>();

    private void Start()
    {
        DisableButtonsFromList();
        HideButtonsFromList();
    }

    private void DisableButtonsFromList()
    {
        var buttons = GetComponentsInChildren<Button>();
        for (int i = 0; i < buttons.Length; i++)
        {
            if (_disabledButtonsIndexFromZero.Contains(i))
            {
                buttons[i].interactable = false;
            }
        }
    }

    private void HideButtonsFromList()
    {
        var buttons = GetComponentsInChildren<Button>();
        for (int i = 0; i < buttons.Length; i++)
        {
            if (_hideButtonsIndexFromZero.Contains(i))
            {
                buttons[i].gameObject.SetActive(false);
            }
        }
    }

    public void OpenLevel(int indexFromOne)
    {
        // resetting deaths counter
        DeathsCounter.instance.ResetCounters();
        SceneLoader.LoadHeavy((SceneLoader.Scene)indexFromOne);
    }
}
