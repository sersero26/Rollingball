using System;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      if (other.TryGetComponent(out Player player))
      {
         player.NewCheckpoint(transform.position);
      }
   }
}
