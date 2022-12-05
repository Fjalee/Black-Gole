using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class HyperLinkScript : MonoBehaviour, IPointerClickHandler
{
    Dictionary<String, String> linkMap = new Dictionary<string, string>();

    void Start()
    {
        linkMap.Add("BGM", "https://www.free-stock-music.com/search.php?keyword=space");
        linkMap.Add("Planet_models", "https://assetstore.unity.com/packages/3d/environments/stylized-planet-pack-full-148233");
        linkMap.Add("Skyboxes", "https://assetstore.unity.com/packages/2d/textures-materials/deep-space-skybox-pack-11056");
        linkMap.Add("Asteroids", "https://assetstore.unity.com/packages/3d/environments/sci-fi/asteroids-low-poly-pack-142164");
        linkMap.Add("Asteroids_sound", "https://mixkit.co/free-sound-effects/asteroid/");
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        var text = GetComponent<TextMeshProUGUI>();
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(text, Input.mousePosition, null);
        if (linkIndex > -1)
        {
            var linkId = text.textInfo.linkInfo[linkIndex].GetLinkID();
            Application.OpenURL(linkMap[linkId]);
        }
    }
}
