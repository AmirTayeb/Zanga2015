using UnityEngine;
using System.Collections;

public class hit_door : MonoBehaviour {

	public Transform hit2_door ;
	
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player" && col.gameObject.GetComponent<OpenDoor>().hasFireExtinguisher == true)
		{
			hit2_door.gameObject.SetActive(true);
		}
	}
	
	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			hit2_door.gameObject.SetActive(false);
		}
	}
}
