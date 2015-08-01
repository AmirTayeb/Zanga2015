using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour 
{

    public GameObject door;
    public float forceMag = 10f;
    public bool hasFireExtinguisher;


    private bool doorBroken = false;
    private bool nearDoor = false;
	void Start () 
    {
	
	}
	
	void Update () 
    {
    
        if(nearDoor)
        {
            if (hasFireExtinguisher && Input.GetKeyDown(KeyCode.Q))
            {
                door.GetComponent<Rigidbody>().isKinematic = false;
                door.GetComponent<Rigidbody>().AddForce(Vector3.right * forceMag);
                GameObject.Destroy(door.GetComponent<HingeJoint>(), 1.5f);
                doorBroken = true;

            }
        }
        if (doorBroken)
        {
            GameObject.Destroy(door, 1.5f);
            StartCoroutine(LoadLevelDelayed());
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Door")
        {
            nearDoor = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Door")
        {
            nearDoor = false;
        }
    }

    IEnumerator LoadLevelDelayed()
    {
        yield return new WaitForSeconds(1.5f);
        Application.LoadLevel(1);
    }
}
