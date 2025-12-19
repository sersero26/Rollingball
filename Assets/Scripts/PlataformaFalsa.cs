using System;
using UnityEngine;

public class PlataformaFalsa : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 initialPosition;
    [SerializeField] AudioClip audioClip;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Player>() != null)
        {
            rb.isKinematic = false;
            AudioManager.instance.VFX.PlayOneShot(audioClip);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<ZonaCaida>() != null)
        {
            transform.position = initialPosition;
            rb.isKinematic = true;
        }
    }
}
