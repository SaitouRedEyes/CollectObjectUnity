using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour 
{	
	
	// Update is called once per frame
	void Update () 
	{
		//Performer Tips: 
		//every collider that move need a rigidBody to be transformed into a dinamic collider.
		//kinematic rigidbody use the transforms to move and don't need physics to calculate.
		this.transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}	
}
