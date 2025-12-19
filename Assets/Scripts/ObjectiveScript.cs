using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class ObjectiveScript : MonoBehaviour
{
    [SerializeField] private UnityEvent startTransition;

    void Start()
    {
        StartCoroutine(Transition());
    }

    private IEnumerator Transition()
    {
        yield return new WaitForSeconds(2f);
        startTransition.Invoke();
    }
    
    
    
}
