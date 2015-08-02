using UnityEngine;
using System.Collections;

public class cancel_10min : MonoBehaviour {

	public Transform min_10 ;

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			min_10.gameObject.SetActive(false);
		}
	}
}
