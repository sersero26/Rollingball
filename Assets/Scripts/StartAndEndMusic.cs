using UnityEngine;

public class StartAndEndMusic : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    void Start()
    {
        AudioManager.instance.Music.Stop();
        AudioManager.instance.Music.clip = audioClip;
        AudioManager.instance.Music.Play();
    }
}
