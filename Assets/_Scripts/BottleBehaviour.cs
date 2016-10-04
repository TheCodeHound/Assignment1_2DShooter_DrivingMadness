using UnityEngine;
using System.Collections;

public class BottleBehaviour : MonoBehaviour {

	//Private instance Variable
	private int _speed;

	private Transform _transform;

	//Public Properties
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
		this._transform = this.GetComponent<Transform> (); //get a reference to the transform of my island
		this.Speed = 12;

	}

	// Update is called once per frame
	void Update () {
		this._move ();
		this._borderCheck ();

	}

	/*
	 *This method moves the game object down the screen
	 */
	private void _move() {
		Vector2 newPosition;

		newPosition = this._transform.position;

		newPosition.y -= this.Speed;
		this._transform.position = newPosition;

	}

	/*
	 * This method checks to see if my game object has reached the top border
	 */
	private void _borderCheck() {
		if (this._transform.position.y <= -470) {
			this._reset ();
		}
	}

	/*
	 * This resets the game object to the orginial position
	 */
	private void _reset() {
		Vector2 resetPosition = new Vector2 (Random.Range(-470f, 470f), 480f);
		this._transform.position = resetPosition;
	}
}
