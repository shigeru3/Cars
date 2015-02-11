using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 5;

	// Update is called once per frame
	void Update () {
		float x = Input.GetAxisRaw ("Horizontal");
		float y = Input.GetAxisRaw ("Vertical");
		Vector2 direction = new Vector2 (x, y).normalized;
		rigidbody2D.velocity = direction * speed;
	}
}
