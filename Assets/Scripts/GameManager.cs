using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public int seconds = 0;
    public int minutes = 0;
    
    private void Awake()
    {
        //Si el trono esta vacio se reclama
        if (gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(this.gameObject);
        }
        //Si no me mato
        else
        {
            Destroy(gameObject);
        }
       
    }
   
    public void NextScene(string scene) //Cambio de escenas
    {
        SceneManager.LoadScene(scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}
