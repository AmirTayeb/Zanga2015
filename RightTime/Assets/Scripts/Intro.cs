using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    public Image intro;
    public Image story;
    public Text escText;

    public float delayTime = 1.5f;

    private bool imageSwitched = false;
    void Update()
    {
        StartCoroutine(EscTextShowUp());
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (imageSwitched)
            {
                Application.LoadLevel(2);
            }
            else
            {
                ImageSwitch();
            }
        }
            
        
    }

    void ImageSwitch()
    {
        intro.sprite = story.sprite;
        imageSwitched = true;
    }

    IEnumerator EscTextShowUp()
    {
        yield return new WaitForSeconds(delayTime);
        escText.enabled = true;
    }
}
