using UnityEngine;
using System.Collections;

[RequireComponent (typeof(BoxCollider2D))]

public class HealthScript : MonoBehaviour {

	// Editor attributes
	public int healthPoints = 2;
	public bool isEnemy = true;

	void OnTriggerEnter2D(Collider2D collider) {

		LaserScript shot = collider.gameObject.GetComponent<LaserScript>();

		//Is this a player shot?
		if(shot != null && shot.isEnemyShot != isEnemy) {

			this.healthPoints -= shot.damage; //apply damage
			Destroy(shot.gameObject); //destroy the game object!

			if(this.healthPoints <= 0) {
				Destroy(this.gameObject); //I'm dead! X_X
			}
		}
	}
}
