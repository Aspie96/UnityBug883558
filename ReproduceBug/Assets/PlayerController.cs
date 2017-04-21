using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 4.0F;

	private CharacterController controller;

	void Start () {
		this.controller = this.GetComponent<CharacterController> ();
	}

	void Update () {
		this.controller.Move (new Vector3 (-Input.GetAxis ("Vertical"), 0, 0) * speed * Time.deltaTime);
	}

	void OnControllerColliderHit(ControllerColliderHit info) {
		Debug.Log (info.moveLength / Time.deltaTime);
	}
}
