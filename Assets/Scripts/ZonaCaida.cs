using System;
using UnityEngine;

public class ZonaCaida : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            player.Fall();
        }
    }
}
