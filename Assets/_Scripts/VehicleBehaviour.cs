using UnityEngine;
using System.Collections;

public class VehicleBehaviour : MonoBehaviour {
	private Transform _transform;

	// Use this for initialization
	void Start () {
		this._transform = this.GetComponent<Transform> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		this._transform.position = new Vector2 (Mathf.Clamp (Input.mousePosition.x -400f, -470f, 470f), -280f);
	
	}
}
