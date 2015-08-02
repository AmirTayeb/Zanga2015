using UnityEngine;
using System.Collections;

public class talk_control : MonoBehaviour {

	public Transform talk1;
	public Transform talk2;
	public Transform talk3;
	public Transform talk4;
	public Transform talk5;
	
	public Transform info1;
	public Transform info2;
	public Transform info3;
	
	public Transform enemey;
	
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
			talk1.gameObject.SetActive (true);
			add_count = true;	
		}
		
		if (Input.GetKeyUp (KeyCode.Space) && count == 1) 
		{
			talk1.gameObject.SetActive(false);	
			talk2.gameObject.SetActive(true);
			
			add_count = true;
		}
		
		if (Input.GetKeyUp (KeyCode.Space) && count == 2) 
		{
			
			talk2.gameObject.SetActive(false);	
			Movement.player_control = true;
			info1.gameObject.SetActive(false);
			info2.gameObject.SetActive(true);
			add_count = true;
			
			
		}
		
		
		if (!enemey.gameObject.activeInHierarchy) 
		{
			info2.gameObject.SetActive(false);
			info1.gameObject.SetActive(true);
			talk5.gameObject.SetActive(true);	
			Movement.player_control = false;
			
			
		}
		
		if (Input.GetKeyUp (KeyCode.Space) && count == 3 && !enemey.gameObject.activeInHierarchy) 
		{
			Application.LoadLevel(3);
			
		}
		
		if (add_count) 
		{
			count++;	
			add_count = false;
		}
	}
}
