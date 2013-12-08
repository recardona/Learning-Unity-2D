using UnityEngine;
using System.Collections;

public class FireLaserScript : MonoBehaviour {

	//Editor attributes
	public Transform laserPrefab;
	public float cooldownTimeThreshold = 0.25f; //amount of time (in secs.) between two shots

	private float cooldownTime;

	// Use this for initialization
	private void Start () {
		this.cooldownTime = 0.0f;
	}
	
	// Update is called once per frame
	private void Update () {
		if(this.cooldownTime > 0) {
			this.cooldownTime -= Time.deltaTime;
		}
	}

	/// <summary>
	/// Shoot if possible. (See this.CanShoot)
	/// </summary>
	/// <param name="isEnemy">
	/// 	If set to <c>true</c>, the shot belongs to game enemies. 
	/// 	Otherwise, it belongs to the player.
	/// </param>
	public void Shoot(bool isEnemy) {
		if(this.CanShoot) {
			// we're counting down from the threshold
			this.cooldownTime = this.cooldownTimeThreshold;

			// create a new laser and set it to where I am
			Transform laserTransform = (Transform) Instantiate(laserPrefab);
			laserTransform.position = new Vector2(this.transform.position.x+0.5f, this.transform.position.y);

			LaserScript laser = laserTransform.gameObject.GetComponent<LaserScript>();
			if(laser != null) {
				laser.isEnemyShot = isEnemy; //assign the laser to enemies or the player
			}

			// modify the laser's movement
			MoveScript laserMovement = laserTransform.gameObject.GetComponent<MoveScript>();
			if(laserMovement != null) {

				//if this is a laser that belongs to the enemy, move it toward the player,
				//and vice-versa
				laserMovement.direction = isEnemy ? -Vector2.up : Vector2.up;
			}
		}
	}

	/// <summary>
	/// Is the weapon ready to fire?  
	/// </summary>
	/// <value><c>true</c> if this instance can shoot; otherwise, <c>false</c>.</value>
	public bool CanShoot
	{
		get
		{
			return this.cooldownTime <= 0.0f;
		}
	}
}
