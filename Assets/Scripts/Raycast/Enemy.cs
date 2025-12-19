using System;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private int life = 100;
    [SerializeField] private GameObject luz;
    private int contador = 1;

    public int Damage(int Lifepoints)
    {
        life -= Lifepoints;
        Debug.Log("Me has echo "+ Lifepoints + " de pupa");
        Debug.Log("Me quedan "+life +" de vidita");
       
        if (luz.gameObject.activeSelf == false)
        {
            luz.SetActive(true);
        }
        else
        {
            luz.SetActive(false);
        }
        
        if (life <= 0)
        {
            Debug.Log("Me muri");
            Destroy(gameObject);
        }
        
        return life;
    }

    private void OnDestroy()
    {
        ExplosionFunction();
    }
    
    
    private void OnDrawGizmos()
    {
        Color color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        Gizmos.color = color;
        Gizmos.DrawSphere(this.transform.position, 11);
    }
    
    private void ExplosionFunction()
    {
        Collider[] colliderRadius = Physics.OverlapSphere(this.transform.position, 11);

        foreach (Collider col in colliderRadius)
        {
            Rigidbody rb = col.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(1000, transform.position, 11);
            }
        }
       
    }
}
