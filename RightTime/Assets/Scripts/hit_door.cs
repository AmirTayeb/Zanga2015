using UnityEngine;
using System.Collections;

public class hit_door : MonoBehaviour {

	public Transform close_door ;
	
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player" && col.gameObject.GetComponent<OpenDoor>().hasFireExtinguisher == false)
		{
			close_door.gameObject.SetActive(true);
		}
	}
	
	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			close_door.gameObject.SetActive(false);
		}
	}
}
