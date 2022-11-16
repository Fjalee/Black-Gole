using UnityEngine;

public class StarSoundManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "PlanetBall")
        {
            GameObject.FindGameObjectWithTag("SoundsGlobal").GetComponent<SoundsGlobalManager>().PlayStarCollisionSound();
        }
    }
}
