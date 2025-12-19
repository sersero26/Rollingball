using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Controler : MonoBehaviour
{
   [SerializeField] private GameObject pauseMenu;
   [SerializeField] private GameObject timeAesthetics;
   [SerializeField] private TMP_Text secondsText;
   [SerializeField] private TMP_Text minutesText;
   private float timer;
   private bool paused;
    void Start()
    {
        
    }

  
    void Update()
    {
        timer += Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
                pauseMenu.SetActive(true);
                timeAesthetics.SetActive(false);
                Time.timeScale = 0;
        }

        if (timer >= 1)
        {
            GameManager.gameManager.seconds++;
            if (GameManager.gameManager.seconds <= 9)
            {
                secondsText.text = "0" + GameManager.gameManager.seconds;
            }
            else
            {
                secondsText.text = GameManager.gameManager.seconds.ToString();
            }
            
            timer = 0;
            if (GameManager.gameManager.seconds >= 60)
            {
                GameManager.gameManager.seconds = 0;
                secondsText.text = "0" + GameManager.gameManager.seconds;
                GameManager.gameManager.minutes++;
                if (GameManager.gameManager.minutes <= 9)
                {
                    minutesText.text = "0" + GameManager.gameManager.minutes;
                }
                else
                {
                    minutesText.text = GameManager.gameManager.minutes.ToString();
                }
            }
        }
        
        
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        timeAesthetics.SetActive(true);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        Time.timeScale = 1;
        GameManager.gameManager.seconds = 0;
        GameManager.gameManager.minutes = 0;
        GameManager.gameManager.NextScene("MainCourse");
    }
    public void Quit()
    {
        Time.timeScale = 1;
        GameManager.gameManager.QuitGame();
    }
    
    
}
