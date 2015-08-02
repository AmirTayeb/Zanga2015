using UnityEngine;
using System.Collections;

public class talk_control : MonoBehaviour {

	public Transform P_empty;
	public Transform P_carefull;
	public Transform P_start;
	public Transform P_2_1;
	public Transform P_2_2;
	public Transform P_2_3;
	public Transform P_2_4;
	public Transform P_3;
	public Transform P_4_1;
	public Transform P_4_2;
	public Transform P_5;

	public Transform F_start;
	public Transform F_2_1;
	public Transform F_2_2;
	public Transform F_2_3;
	public Transform F_2_4;
	public Transform F_3;
	public Transform F_4_1;
	public Transform F_4_2;

	public Transform End_1;
	public Transform End_2;
	public Transform End_3;
	public Transform End_4;
	public Transform End_5;
	public Transform info;
	public Transform press;
	public bool add_count; 
	public Transform bck;
	public Transform exit;

	public int count =0 ;
	// Use this for initialization
	void Start () 
	{
		count = 0 ;
		add_count = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (count == 0) 
		{
			StartCoroutine(delayedTime());
			add_count = true;
		}
		
		if (Input.GetKeyUp (KeyCode.Space) && count == 1) 
		{
			press.gameObject.SetActive(false);
			P_start.gameObject.SetActive(false);
			F_start.gameObject.SetActive(false);
			P_empty.gameObject.SetActive(true);
			P_carefull.gameObject.SetActive(true);
			P_2_1.gameObject.SetActive(true);
			P_2_2.gameObject.SetActive(true);
			P_2_3.gameObject.SetActive(true);
			P_2_4.gameObject.SetActive(true);

			add_count = true;
		}
		
		if (Input.GetKeyUp (KeyCode.Space) && count == 2) 
		{
			F_2_2.gameObject.SetActive(false);
			press.gameObject.SetActive(false);
			P_3.gameObject.SetActive(true);
			F_3.gameObject.SetActive(true);

			add_count = true;
			
			
		}
		
		if (Input.GetKeyUp (KeyCode.Space) && count == 3) 
		{
			F_2_2.gameObject.SetActive(false);
			press.gameObject.SetActive(false);
			P_3.gameObject.SetActive(true);
			F_3.gameObject.SetActive(true);
			
			add_count = true;
			
			
		}

		if (Input.GetKeyUp (KeyCode.Space) && count == 4) 
		{
			F_3.gameObject.SetActive(false);
			P_3.gameObject.SetActive(false);
			press.gameObject.SetActive(false);
			P_4_1.gameObject.SetActive(true);
			P_4_2.gameObject.SetActive(true);
			P_empty.gameObject.SetActive(true);
			P_carefull.gameObject.SetActive(true);
			
			add_count = true;
			
			
		}

		if (count == 3) 
		{
			press.gameObject.SetActive(true);
		}
		

		
		if (add_count) 
		{
			count++;	
			add_count = false;
		}
	}

	IEnumerator delayedTime()
	{
		P_start.gameObject.SetActive(true);
		yield return new WaitForSeconds(1f);
		F_start.gameObject.SetActive(true);
		press.gameObject.SetActive(true);
	}

	public void first_pick()
	{
		P_empty.gameObject.SetActive(false);
		P_carefull.gameObject.SetActive(false);
		P_2_1.gameObject.SetActive(false);
		P_2_2.gameObject.SetActive(false);
		P_2_3.gameObject.SetActive(false);
		P_2_4.gameObject.SetActive(false);
		F_2_1.gameObject.SetActive(true);
		End_1.gameObject.SetActive (true);
		bck.gameObject.SetActive (true);
		exit.gameObject.SetActive (true);
		friend_animation_control.player_fail = true;

	}

	public void second_pick()
	{
		P_empty.gameObject.SetActive(false);
		P_carefull.gameObject.SetActive(false);
		P_2_1.gameObject.SetActive(false);
		P_2_2.gameObject.SetActive(false);
		P_2_3.gameObject.SetActive(false);
		P_2_4.gameObject.SetActive(false);
		F_2_2.gameObject.SetActive(true);
		press.gameObject.SetActive(true);

	}

	public void third_pick()
	{
		P_empty.gameObject.SetActive(false);
		P_carefull.gameObject.SetActive(false);
		P_2_1.gameObject.SetActive(false);
		P_2_2.gameObject.SetActive(false);
		P_2_3.gameObject.SetActive(false);
		P_2_4.gameObject.SetActive(false);
		F_2_3.gameObject.SetActive(true);
		End_3.gameObject.SetActive (true);
		bck.gameObject.SetActive (true);
		exit.gameObject.SetActive (true);
		friend_animation_control.player_fail = true;
		
	}

	public void forth_pick()
	{
		P_empty.gameObject.SetActive(false);
		P_carefull.gameObject.SetActive(false);
		P_2_1.gameObject.SetActive(false);
		P_2_2.gameObject.SetActive(false);
		P_2_3.gameObject.SetActive(false);
		P_2_4.gameObject.SetActive(false);
		F_2_4.gameObject.SetActive(true);
		End_4.gameObject.SetActive (true);
		bck.gameObject.SetActive (true);
		exit.gameObject.SetActive (true);
		friend_animation_control.player_fail = true;
		
	}

	public void forth1_pick()
	{
		P_4_1.gameObject.SetActive(false);
		P_4_2.gameObject.SetActive(false);
		P_empty.gameObject.SetActive(false);
		P_carefull.gameObject.SetActive(false);
		End_2.gameObject.SetActive (true);
		F_4_1.gameObject.SetActive(true);
		bck.gameObject.SetActive (true);
		exit.gameObject.SetActive (true);
		friend_animation_control.player_fail = true;
		
	}

	public void forth2_pick()
	{
		P_4_1.gameObject.SetActive(false);
		P_4_2.gameObject.SetActive(false);
		P_empty.gameObject.SetActive(false);
		P_carefull.gameObject.SetActive(false);
		F_4_2.gameObject.SetActive(true);
		End_5.gameObject.SetActive (true);
		bck.gameObject.SetActive (true);
		exit.gameObject.SetActive (true);

	}

	public void BackToMainMenu()
	{
		Application.LoadLevel(0);
	}
	
	public void ExitGame()
	{
		Application.Quit();
	}
}
