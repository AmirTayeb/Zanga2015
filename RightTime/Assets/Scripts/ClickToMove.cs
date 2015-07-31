using UnityEngine;
using System.Collections;

public class ClickToMove : MonoBehaviour {

		//movement
	public float speed = 10;


	public CharacterController controller;


	//public AnimationClip run;
	//public AnimationClip idle;

	public static bool attack;
	public static bool die;

	private Vector3 position;
//	private Vector3 moveDirection = Vector3.zero;

	void Start () 
	{
		position = transform.position;
	}
	

	void Update ()
	{
		if(!attack && !die)
		{
			if(Input.GetMouseButtonDown(0))
			{

				//locate where the position where the player clicked on the terrain
				LocatePosition();
			}
			// move the player to the position 
			MoveToPosition ();
		
		}
		else
		{

		}
	}
	void LocatePosition()
	{
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if(Physics.Raycast(ray, out hit, 1000))
		{
			if(hit.collider.tag != "Player" && hit.collider.tag != "Enemy")
			{
				position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
			}
		}
	}

	void MoveToPosition()
	{
		if(Vector3.Distance(transform.position, position) > 1)
		{
			Quaternion newRotation = Quaternion.LookRotation (position - transform.position);
			newRotation.x = 0;
			newRotation.z = 0;
			transform.rotation = Quaternion.Slerp (transform.rotation, newRotation, Time.deltaTime * 10);
			controller.SimpleMove (transform.forward * speed);

		//	animation.CrossFade(run.name);
		}
		//else
	//	{
		//	//animation.CrossFade(idle.name);
	//	}
	}

}
