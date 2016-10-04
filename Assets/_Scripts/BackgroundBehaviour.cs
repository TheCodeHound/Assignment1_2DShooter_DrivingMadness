using UnityEngine;
using System.Collections;

public class BackgroundBehaviour : MonoBehaviour {

	//Private instance Variable
	private int _speed;
	private Transform _transform;

	//Public speed property for background
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
		this._transform = this.GetComponent<Transform> (); //get a reference to the transform of my street
		//Speed is 30
		this.Speed = 30;

	}

	// Update is called once per frame
	void Update () {
		//Calls private method move and borderCheck
		this._move ();
		this._borderCheck ();

	}

	// Method moves the background down the screen with a set speed
	private void _move() {
		Vector2 newPosition;
		newPosition = this._transform.position;
		newPosition.y -= this.Speed;
		this._transform.position = newPosition;

	}

	// Method checks to see if my background has reached the top border
	private void _borderCheck() {
		if (this._transform.position.y <= -831) {
			this._reset ();
		}
	}

	// Resets the background to the orginial position
	private void _reset() {
		Vector2 resetPosition = new Vector2 (0f, 374f);
		this._transform.position = resetPosition;
	}
}
