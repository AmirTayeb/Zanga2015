using UnityEngine;
using System.Collections;

public class CameraTrack : MonoBehaviour 
{
    private Transform player;
    private Vector3 newPos;
    private Vector3 relCamPos;
    private float relCamPosMag;
    private float smooth = 1.5f;
     
    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        relCamPos = transform.position - player.position;
        relCamPosMag = relCamPos.magnitude - .5f;
	}
	
	void Update ()
    {
        Vector3 standardPos = relCamPos + player.position;
        Vector3 abovePos = player.position + Vector3.up * relCamPosMag;
        Vector3[] checkPoints = new Vector3[5];
        checkPoints[0] = standardPos;
        checkPoints[1] = Vector3.Lerp(standardPos, abovePos, .25f);
        checkPoints[2] = Vector3.Lerp(standardPos, abovePos, .5f);
        checkPoints[3] = Vector3.Lerp(standardPos, abovePos, .75f);
        checkPoints[4] = abovePos;

        for (int i = 0; i < checkPoints.Length; i++)
        {
            if (ViewingPosCheck(checkPoints[i]))
            {
                break;
            }
        }
        transform.position = Vector3.Lerp(transform.position, newPos, smooth * Time.deltaTime);
        SmoothLookAt();
 	}

    bool ViewingPosCheck(Vector3 checkPos)
    {
        RaycastHit hit;
        if (Physics.Raycast(checkPos, player.position - checkPos, out hit, relCamPosMag))
        {
            if (hit.transform != player)
            {
                return false;
            }
        }
        newPos = checkPos;
        return true;
    }

    void SmoothLookAt()
    {
        Vector3 relPlayerPos = player.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(relPlayerPos, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, smooth * Time.deltaTime);
    }
}
