using System;
using UnityEngine;

public class PropulsiónTrigger : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 direction;
    [SerializeField] private float propulsionForce;
    private void OnTriggerEnter(Collider other)
    {
        rb = other.attachedRigidbody;
        rb.AddForce(direction * propulsionForce , ForceMode.Impulse);
    }
    
}
