using UnityEngine;

public class RayCast_Exercise : MonoBehaviour
{
    [SerializeField] private float rayDistance;
    [SerializeField] private int damage;
    [SerializeField] private float area;
    [SerializeField] private float impactForce;
    [SerializeField] private float alfa;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayHitFunction();
        }

        if (Input.GetMouseButtonDown(1))
        {
            OverlapFunction();
        }
    }

    void RayHitFunction() //Solo funciona con fisicas y solo si choca con algo
    {
        RaycastHit impactInfo;

        if (Physics.Raycast(this.transform.position, Vector3.forward, out impactInfo))
        {
            Debug.DrawRay(this.transform.position, Vector3.forward * rayDistance, Color.red,2f);
        }

        Rigidbody rbHit = impactInfo.rigidbody;
        Debug.Log(rbHit);

        rbHit.GetComponent<Enemy>().Damage(damage);
    }


    private void OnDrawGizmos()
    {
        Color color = new Color(0.5f, 0.5f, 0.5f, alfa);
        Gizmos.color = color;
        Gizmos.DrawSphere(this.transform.position, area);
    }
    
    private void OverlapFunction()
    {
        Collider[] colliderRadius = Physics.OverlapSphere(this.transform.position, area);

        foreach (Collider col in colliderRadius)
        {
           Rigidbody rb = col.GetComponent<Rigidbody>();
           if (rb != null)
           {
               rb.AddExplosionForce(impactForce, transform.position, area);
           }
        }
       
    }
}
