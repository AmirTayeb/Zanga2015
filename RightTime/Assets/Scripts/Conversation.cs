using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Conversation : MonoBehaviour
{
    public Sprite[] playerChats;
    public Sprite[] friendChats;

    public Sprite[] nextPlayerChat;
    public Sprite[] nextFriendChats;


    public GameObject playerUI;
    public GameObject friendUI;

    int x = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            x++;
            if (x >= playerChats.Length)
                x = playerChats.Length - 1;
            playerUI.GetComponent<Image>().sprite = playerChats[x];

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            x--;
            if (x <= 0)
                x = 0;
            playerUI.GetComponent<Image>().sprite = playerChats[x];

        }
    }

    public void SwitchConv()
    {
        if(x != 0)
        {
            friendUI.GetComponent<Image>().sprite = friendChats[x];
            nextPlayerChat.CopyTo(playerChats, 0);
            nextFriendChats.CopyTo(friendChats, 0);
            friendUI.GetComponent<Image>().sprite = nextFriendChats[x];
        }
        
    }

	
}
