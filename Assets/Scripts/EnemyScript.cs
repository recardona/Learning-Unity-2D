using UnityEngine;
using System.Collections;

/// <summary>
/// Generic Enemy Behavior
/// </summary>
public class EnemyScript : MonoBehaviour {

	private FireLaserScript laser;

	// Awake is called when the script is loaded
	private void Awake () {
		//retrieve the weapon!
		laser = GetComponent<FireLaserScript>();
	}

	// Update is called once per frame
	void Update () {
		// Auto-fire
		if (laser != null && laser.CanShoot) {
			laser.Shoot(true); //it's true, this is an enemy shooting
		}
	}
}
