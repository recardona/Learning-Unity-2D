using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	// Editor attributes
	public Vector2 speed = new Vector2(5,5);
	public Vector2 direction = -Vector2.up;

	// Update is called once per frame
	private void Update () {

		float velocityX = speed.x * direction.x;
		float velocityY = speed.y * direction.y;

		Vector3 movement = new Vector3(velocityX, velocityY, 0);

		movement *= Time.deltaTime;
		this.transform.Translate(movement);
	}
}
