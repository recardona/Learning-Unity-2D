using System;
using UnityEngine;

[RequireComponent (typeof (SpriteRenderer))]

public class PlayerScript : MonoBehaviour {

	// Editor attributes
 	public Vector2 speed = new Vector2(10,10);

	// Update is called once per frame
	void Update () {

		//Player input is flipped because Sprite is rotated
		//-1 is used to adjust horiz input to move in the right direction
		float inputX = Input.GetAxis("Vertical");
		float inputY = -Input.GetAxis("Horizontal");

		float velocityX = speed.x * inputX;
		float velocityY = speed.y * inputY;

		//Calculate movement vector, and normalize with time
		Vector3 movement = new Vector3(velocityX, velocityY, 0);
		movement *= Time.deltaTime;

		//transform this
		this.transform.Translate(movement);



	}
}
