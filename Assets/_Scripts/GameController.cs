using UnityEngine;
using System.Collections;

// needed for UI elements
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	// Private instance variables for lives and score
	private int _scoreValue = 0;
	private int _livesValue = 5;

	// Public instance variables to test lives, score, cones, wheels, bottles
	public Text LivesLabel;
	public Text ScoreLabel;
	public int coneNumber = 1;
	public GameObject Cone;
	public int wheelNumber = 1;
	public GameObject Wheel;
	public int bottleNumber = 1;
	public GameObject Bottle;

	// Public property for score
	public int ScoreValue {
		get {
			return this._scoreValue;
		}
		set {
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}
	//Public property for lives
	public int LivesValue {
		get {
			return this._livesValue;
		} set {
			this._livesValue = value;
			this.LivesLabel.text = "Lives: " + this._livesValue;
		}
	}

	// Use this for initialization
	void Start () {

		// repeat coneCount times
		for (int coneCount = 0; coneCount < this.coneNumber; coneCount++) {
			Instantiate (this.Cone);
		}

		// repeat wheelCount times
		for (int wheelCount = 0; wheelCount < this.wheelNumber; wheelCount++) {
			Instantiate (this.Wheel);
		}

		// repeat bottleCount times
		for (int bottleCount = 0; bottleCount < this.bottleNumber; bottleCount++) {
			Instantiate (this.Bottle);
		}

	}

	// Update is called once per frame
	void Update () {

	}
}
