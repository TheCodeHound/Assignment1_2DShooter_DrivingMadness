using UnityEngine;
using System.Collections;

public class VehicleBehaviour : MonoBehaviour {

	//Private Instance Variables
	private Transform _transform;

	// Public instance variable for gameController
	public GameController gameController;

	// Use this for initialization
	void Start () {
		this._transform = this.GetComponent<Transform> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		//Calls private method
		this._movePlayer ();
	}

	//Allows player to move car
	private void _movePlayer() {
		//Allows the player to move the vehicle left and right with the mouse
		this._transform.position = new Vector2 (Mathf.Clamp (Input.mousePosition.x -400f, -470f, 470f), -280f);
	}

	//Detects when vehicle collides with objects
	private void OnTriggerEnter2D(Collider2D other) {

		//Adds +100 when vehicle hits cone
		if (other.gameObject.CompareTag ("Cone")) {
			//Cone hit detection
			Debug.Log ("Cone Hit!");
			this.gameController.ScoreValue += 100;
		}
		//Takes away 1 life when vehicle hit by wheel
		if (other.gameObject.CompareTag ("Wheel")) {
			//Wheel hit detection
			Debug.Log ("Wheel Hit!");
			this.gameController.LivesValue -= 1;
		}
		//Adds 200 points when vehicle hits bottle
		if (other.gameObject.CompareTag ("Bottle")) {
			//Bottle hit detection
			Debug.Log ("Bottle Hit!");
			this.gameController.ScoreValue += 200;
		}

	}
}
