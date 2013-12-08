using UnityEngine;
using System.Collections;

public class LaserScript : MonoBehaviour {

	// Editor attributes
	public int damage = 1;
	public bool isEnemyShot = false;

	// Use this for initialization
	private void Start () {
		Destroy(gameObject, 5); //5 second time-to-live
	}
	
	// Update is called once per frame
	private void Update () {
	
	}
}
