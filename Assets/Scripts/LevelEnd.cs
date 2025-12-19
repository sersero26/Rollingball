using System;
using UnityEngine;
using UnityEngine.Events;

public class LevelEnd : MonoBehaviour
{
   [SerializeField] UnityEvent EndGame;
   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.GetComponent<Player>() != null)
      {
         EndGame.Invoke();
      }
   }
}
