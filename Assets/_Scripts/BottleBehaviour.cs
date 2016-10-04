using UnityEngine;
using System.Collections;

public class BottleBehaviour : MonoBehaviour {

	//Private speed instance variable for bottle
	private int _speed;
	private Transform _transform;

	//Public speed property for bottle
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
		this._transform = this.GetComponent<Transform> (); //get a reference to the transform of my bottle
		// Moves the bottle at a speed of 12
		this.Speed = 12;

	}

	// Update is called once per frame
	void Update () {
		// Calls private method move and borderCheck
		this._move ();
		this._borderCheck ();

	}

	// Method moves the bottle down the screen with set speed
	private void _move() {
		Vector2 newPosition;
		newPosition = this._transform.position;
		newPosition.y -= this.Speed;
		this._transform.position = newPosition;

	}

	// Method checks to see if my bottle has reached the top border
	private void _borderCheck() {
		if (this._transform.position.y <= -470) {
			this._reset ();
		}
	}

	// Resets the bottle to the orginial position
	private void _reset() {
		Vector2 resetPosition = new Vector2 (Random.Range(-470f, 470f), 480f);
		this._transform.position = resetPosition;
	}
}
