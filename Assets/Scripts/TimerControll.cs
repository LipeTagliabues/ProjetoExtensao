using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerControll : MonoBehaviour
{
    [SerializeField] private TMP_Text txttime;
    [SerializeField] private float timevalue;

    void Start()
    {
        InvokeRepeating("DecreaseTime", 1f, 1f);
    }

    private void DecreaseTime()
    {
        if (timevalue <= 0f)
        {
            timevalue = 0f;
            EndTimer();
        }
        else
        {
            timevalue--;
            DisplayTime(timevalue);
        }
    }

    private void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        txttime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void EndTimer()
    {
        SceneManager.LoadScene(11);
    }
}
