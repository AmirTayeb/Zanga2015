using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
    public Text countDownTime;
    public float gameTimeInMintues = 10;

    private float timeInMinutes;
    private string timeToDisplay;

    private int seconds;
    private int minutes;


    void Start () 
    {
        timeInMinutes = gameTimeInMintues * 60;
        seconds = (int)(timeInMinutes % 60);
        minutes = (int)(timeInMinutes / 60);

        timeToDisplay = string.Format("{0:00}:{1:00}", minutes, seconds); 
        countDownTime.text = timeToDisplay;
	}
	
	void Update () 
    {
        StartCoroutine(CountDown());
	}

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(1f);
        timeInMinutes -= Time.deltaTime;
        if (timeInMinutes <= 0)
            timeInMinutes = 0;

        seconds = (int)(timeInMinutes % 60);
        minutes = (int)(timeInMinutes / 60);

        timeToDisplay = string.Format("{0:00}:{1:00}", minutes, seconds);

        countDownTime.text = timeToDisplay;

    }

}
