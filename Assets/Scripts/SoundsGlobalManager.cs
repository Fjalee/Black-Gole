using UnityEngine;

public class SoundsGlobalManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource _starCollisionSound;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void PlayStarCollisionSound()
    {
        _starCollisionSound.Play();
    }
}
