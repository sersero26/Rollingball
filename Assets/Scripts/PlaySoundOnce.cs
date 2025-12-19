using UnityEngine;

public class PlaySoundOnce : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    private bool playedOnce = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() && playedOnce == false )
        {
            AudioManager.instance.VFX.PlayOneShot(audioClip);
            playedOnce = true;
        }
    }
}
