using System;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
   [SerializeField] AudioClip audioClip;
   private void OnTriggerEnter(Collider other)
   {
      if (other.GetComponent<Player>())
      {
         AudioManager.instance.VFX.PlayOneShot(audioClip);
      }
   }
}
