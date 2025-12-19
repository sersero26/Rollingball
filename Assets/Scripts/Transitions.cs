using UnityEngine;
using System.Collections;

public class Transitions : MonoBehaviour
{
    private Animator animator;
    [SerializeField] string nextScene;
    [SerializeField] AudioClip audioClip;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    public void Transicion()
    {
        animator.Play("Transition enter");
        StartCoroutine(Wait(nextScene));
    }

    private IEnumerator Wait(string sceneName)
    {
        yield return new WaitForSeconds(1);
        AudioManager.instance.VFX.PlayOneShot(audioClip);
        GameManager.gameManager.NextScene(sceneName);
    }
}
