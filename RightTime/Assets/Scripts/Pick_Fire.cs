using UnityEngine;
using System.Collections;

public class Pick_Fire : MonoBehaviour {

	public GameObject pick_talk ;

	void OnTriggerEnter(Collider col) 
	{
		if (col.gameObject.tag == "Player") 
		{
			pick_talk.SetActive(true)  ;

			col.gameObject.GetComponent<Player_animCTR>().close_to_fire = true ;
		}


	}

	void OnTriggerExit(Collider col) 
	{
		if (col.gameObject.tag == "Player") 
		{
			pick_talk.SetActive(false)  ;
			
		}
		
		
	}


}
