using UnityEngine;
using System.Collections;

// needed for UI elements
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	// PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++
	private int _scoreValue = 0;
	private int _livesValue = 5;

	// PUBLIC INSTANCE VARIABLES (FOR TESTING) +++++++++++++++++++++++++++
	public Text LivesLabel;
	public Text ScoreLabel;


	// PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++
	public int ScoreValue {
		get {
			return this._scoreValue;
		}

		set {
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}

	public int LivesValue {
		get {
			return this._livesValue;
		}

		set {
			this._livesValue = value;
			this.LivesLabel.text = "Lives: " + this._livesValue;
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
