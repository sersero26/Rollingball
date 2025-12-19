using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    /*PatronSingleton
        1.Solo existe uno
        2.Accesible desde cualquier punto del programa*/

    [SerializeField] public AudioSource Music;
    [SerializeField] public AudioSource VFX;
    
    public static AudioManager instance;//el trono
    private void Awake()
    {
        //Si el trono esta vacio se reclama
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        //Si no me mato
        else
        {
            Destroy(gameObject);
        }
       
    }
}
