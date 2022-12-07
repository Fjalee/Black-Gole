using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class DeathsCounter : MonoBehaviour
{
    public static DeathsCounter instance = null;

    private static int deathByStar { get; set; }
    private static int deathBySpace { get; set; }
    private void Awake()
    {

        if (this.gameObject.name == "DeathCounter")
        {
            DisplayDeathCounter();
        }


        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void AddDeathByStar()
    {
        deathByStar++;
    }

    public void AddDeathBySpace()
    {
        deathBySpace++;
    }

    public void ResetCounters()
    {
        deathBySpace = 0;
        deathByStar = 0;
    }

    private void DisplayDeathCounter()
    {
        if (deathBySpace == 0 && deathByStar == 0)
        {
            return;
        }
        foreach (var child in this.gameObject.GetComponentsInChildren<TextMeshProUGUI>())
        {
            if (child.name == "DeathCounterText")
            {
                child.text = "During this journey, planet ball was lost due to various reasons...\n Burned by stars: " + deathByStar + "\nLost in space: " + deathBySpace;
            }
        }

    }

}
