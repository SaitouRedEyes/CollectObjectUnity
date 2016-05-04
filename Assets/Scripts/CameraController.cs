using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
	//public GameObject player;
	private PlayerController player;
	private Vector3 offset;
	
	// Use this for initialization
	void Start () 
	{
		player = (PlayerController)GameObject.FindObjectOfType(typeof(PlayerController));
		
		//Calculating the distance between camera and player
		offset = this.transform.position - player.transform.position;		
	}
	
	//LateUpdate is called once per frame, after Update has finished. 
	//Any calculations that are performed in Update will have completed when LateUpdate begins. 
	void LateUpdate () { this.transform.position = player.transform.position + offset; }
}
