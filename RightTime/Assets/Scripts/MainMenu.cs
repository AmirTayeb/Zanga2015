using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour 
{
    public GameObject creditsPanel;
    public GameObject MainMenuPanel;

    public void NewGame()
    {
        Application.LoadLevel(1);
    }

    public void Credits()
    {
        creditsPanel.SetActive(true);
        MainMenuPanel.SetActive(false);  
    }
    
    public void Back()
    {
        creditsPanel.SetActive(false);
        MainMenuPanel.SetActive(true);
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
