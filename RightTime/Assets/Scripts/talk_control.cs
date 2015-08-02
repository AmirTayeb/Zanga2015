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
	
	public bool add_count; 
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
			P_start.gameObject.SetActive(true);
			F_start.gameObject.SetActive(true);
			add_count = true;	
		}
		
		if (Input.GetKeyUp (KeyCode.Space) && count == 1) 
		{

			
			add_count = true;
		}
		
		if (Input.GetKeyUp (KeyCode.Space) && count == 2) 
		{
			

			add_count = true;
			
			
		}
		
		
	
		

		
		if (add_count) 
		{
			count++;	
			add_count = false;
		}
	}
}
