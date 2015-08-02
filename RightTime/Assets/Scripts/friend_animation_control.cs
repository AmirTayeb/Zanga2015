using UnityEngine;
using System.Collections;

public class friend_animation_control : MonoBehaviour {

	Animator anim;
	int gun_2head_Hash = Animator.StringToHash("gun_2head");
	int end_Hash = Animator.StringToHash("end");
	static public bool player_fail = false ;
	
	void Start ()
	{
		anim = GetComponent<Animator>();
		anim.SetBool(gun_2head_Hash,true);
	}
	
	
	void Update ()
	{
		if(player_fail == true)
		{
			anim.SetBool (end_Hash,true);
		}

	}
}
