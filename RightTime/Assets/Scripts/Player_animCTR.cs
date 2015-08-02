using UnityEngine;
using System.Collections;

public class Player_animCTR : MonoBehaviour {

	Animator anim;
	int Pick_Hash = Animator.StringToHash("Pick");
	int attack_Hash = Animator.StringToHash("attack");
	int hold_item_Hash = Animator.StringToHash("hold_item");
	public bool close_to_fire = false ; 
	public bool picked = false ;
	public Transform fire ;
	public Transform hand ; 
	public bool able_attack = false ;
	public Transform player ;
	public GameObject pick_talk ;

	void Start ()
	{
		anim = GetComponent<Animator>();
	}
	
	
	void Update ()
	{
		if(close_to_fire == true && Input.GetKey(KeyCode.P) && picked == false)
		{
			anim.SetTrigger (Pick_Hash);
			picked = true ;
		}

		if(picked)
		{
			anim.SetBool(hold_item_Hash,true);
			fire.transform.parent = hand.transform ;
			fire.transform.localPosition = new Vector3(0,0,-0.0009699861f);
			fire.transform.localRotation = new Quaternion(-0.95f,0,0,1);
			picked = false ;
			able_attack = true;
			pick_talk.SetActive(false) ;
			player.gameObject.GetComponent<OpenDoor>().hasFireExtinguisher = true ;

		}

		if (able_attack && Input.GetKey (KeyCode.C)) 
		{
			anim.SetTrigger(attack_Hash);
		}
	}

}
