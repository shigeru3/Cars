using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speedX = 5;
	public float speedY = 1;

	// Update is called once per frame
	void Update () {
		float x = Input.GetAxisRaw ("Horizontal");
		Vector2 direction = new Vector2 (x, 0).normalized;
		rigidbody2D.velocity = direction * speedX;

		float y = Input.GetAxisRaw ("Vertical");
		if (y > 0) {
			GameObject.Find ("Backgrounds").GetComponent<Speed> ().speed += 0.005f;
		} else if (y < 0) {
			GameObject.Find ("Backgrounds").GetComponent<Speed> ().speed -= 0.007f;
		}
	}
}
