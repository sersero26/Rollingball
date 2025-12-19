using System;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] float fuerza;
   [SerializeField] float saltofuerza;
   [SerializeField] private float interactionRadius;
   [SerializeField] private AudioClip audioClip;
   [SerializeField] private float rayCastDistance;
   
   private Vector3 checkpoint;
   
   private Rigidbody rb;
    
   private float hInput;
   private float vInput;

   private Vector3 InteractionPoint;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        checkpoint = transform.position;
        NewCheckpoint(transform.position);
    }
    
    //Hace update cada 0.02 segundos (SE USA PARA LAS FISICAS)
    private void FixedUpdate()
    {
        MovimientoBola();
    }

    private void Update()
    {
        Jump();
        Interactions();
    }

    private void Interactions()
    {
       if (Input.GetKeyDown(KeyCode.E))
       {
           InteractionPoint = transform.position + Vector3.forward * 0.5f;
           Collider[] results = Physics.OverlapSphere(InteractionPoint,  interactionRadius);
           if (results.Length > 0)
           {
               foreach (Collider result in results)
               {
                   if (result.gameObject.TryGetComponent(out Boton botonScript)) //Dos por uno
                   {
                       botonScript.OpenDoor();
                   }
               }
           }
       }
    }
    
    private void MovimientoBola()
    {
        Vector3 movimiento = new Vector3(hInput, 0f, vInput).normalized;
        
        rb.AddForce(movimiento * fuerza, ForceMode.Force);
        
    }

    private void Jump()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Si el rayo impacta con algo, entonces solo en ese caso podemos saltar
            if(Physics.Raycast(transform.position, Vector3.down,rayCastDistance))
            {
                AudioManager.instance.VFX.PlayOneShot(audioClip);
                rb.AddForce(Vector3.up * saltofuerza, ForceMode.Impulse);
            }

        }
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(InteractionPoint, interactionRadius);
       
    }

    public void NewCheckpoint(Vector3 newPosition)
    {
        checkpoint = newPosition;
    }

    public void Fall()
    {
        rb.linearVelocity = Vector3.zero;
        transform.position = checkpoint;
    }
}
