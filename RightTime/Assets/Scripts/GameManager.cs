using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
    public Text countDownTime;

    public float gameTime = 10;

    private float timeInMinutes;
    private float startTime;
    private float endTime;
    private float second = 1000000000;
	// Use this for initialization
	void Start () 
    {
        timeInMinutes = gameTime * 60;
        startTime = Time.time + timeInMinutes;
        countDownTime.text = "Time: " + startTime.ToString();
        endTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (startTime > endTime)
        {
            second -= Time.deltaTime;
            if (second == 0)
            {
                startTime--;
                countDownTime.text = "Time: " + startTime.ToString();
                second = 1000000000;
            }
        }
	}
}
