using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{
	//Public properties could be changed direct in the editor. 
	public float speed;
	public Text scoreText, winText;
	private int numberOfCoins, numberOfCoinsCollected;	
	
	void Start() 
	{ 
		numberOfCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
		numberOfCoinsCollected = 0; 
		SetCountText();		
	}
	
	//FixedUpdate is called before physics calculations.
	void FixedUpdate()
	{
		//Click on the class and press Control + ' to see the documentation of the class.
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
		
		//Time.deltaTime is used to move the object independent from the FPS of the game.
		//In this case is speed units / seconds
		GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
	}
	
	void OnTriggerEnter(Collider otherCollider)
	{
		//Destroy (otherCollider.gameObject);
		
		if(otherCollider.gameObject.tag.Equals("Coin"))
		{
			otherCollider.gameObject.SetActive(false);
			numberOfCoinsCollected++;
			SetCountText();
		}
	}
	
	private void SetCountText() 
	{ 
		scoreText.text = "Coins: " + numberOfCoinsCollected; 
		
		if(numberOfCoinsCollected >= numberOfCoins) winText.gameObject.SetActive(true);
	}
}