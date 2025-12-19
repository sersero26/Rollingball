using TMPro;
using UnityEngine;

public class EndScore : MonoBehaviour
{
    [SerializeField] private TMP_Text minutesT;
    [SerializeField] private TMP_Text secondsT;
    void Start()
    {
        if (GameManager.gameManager.minutes <= 9)
        {
            minutesT.text = "0"  + GameManager.gameManager.minutes;
        }
        else
        {
            minutesT.text = GameManager.gameManager.minutes.ToString();
        }

        if (GameManager.gameManager.seconds <= 9)
        {
            secondsT.text = "0"  + GameManager.gameManager.seconds;
        }
        else
        {
            secondsT.text = GameManager.gameManager.seconds.ToString();
        }
        
        GameManager.gameManager.minutes = 0;
        GameManager.gameManager.seconds = 0;
    }
}
