using UnityEngine;
using System.Collections;

public class LaserScript : MonoBehaviour {

	// Editor attributes
	public int damage = 1;
	public bool isEnemyShot = false;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 20); //20 second time-to-live
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
