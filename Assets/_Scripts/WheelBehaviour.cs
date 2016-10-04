using UnityEngine;
using System.Collections;

public class WheelBehaviour : MonoBehaviour {

	//Private speed instance variable for wheel
	private int _speed;
	private Transform _transform;

	//Public speed properties for wheel
	public int Speed {
		get {
			return this._speed;
		}
		set {
			this._speed = value;
		}
	}

	// Use this for initialization
	void Start () {
		this._transform = this.GetComponent<Transform> (); //get a reference to the transform of my wheel
		// Moves the wheel at a speed of 7
		this.Speed = 7;

	}

	// Update is called once per frame
	void Update () {
		// Calls private method move and borderCheck
		this._move ();
		this._borderCheck ();

	}

	//This method moves the wheel down the screen
	private void _move() {
		Vector2 newPosition;
		newPosition = this._transform.position;
		newPosition.y -= this.Speed;
		this._transform.position = newPosition;

	}

	//Checks to see if my game object has reached the top border
	private void _borderCheck() {
		if (this._transform.position.y <= -470) {
			this._reset ();
		}
	}

	//Resets the wheel to the orginial position
	private void _reset() {
		Vector2 resetPosition = new Vector2 (Random.Range(-470f, 470f), 480f);
		this._transform.position = resetPosition;
	}
}
