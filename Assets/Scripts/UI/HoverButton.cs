
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverButton : MonoBehaviour, IPointerEnterHandler , IPointerExitHandler
{
    [SerializeField] AudioClip audioClip;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
        AudioManager.instance.VFX.PlayOneShot(audioClip);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ClickedExit();
    }

    public void ClickedExit()
    {
        gameObject.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
    }
}
