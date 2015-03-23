using UnityEngine;
using System.Collections;

public class Speed: MonoBehaviour {
		public GameObject Front;
		public GameObject Back;
		public GameObject Middle;

		public float speed = 0.0f;
		public float speedMax = 0.6f;
		public float speedMin = 0.0f;

		float position = 0.0f;

		void Update() {
				if (speed > speedMax) {
						speed = speedMax;
				} else if (speed < speedMin) {
						speed = speedMin;
				}
				position += speed;
				float frontY = Mathf.Repeat (position * 0.1f, 1);
				float backY = Mathf.Repeat (position * 0.06f, 1);
				float middleY = Mathf.Repeat (position * 0.08f, 1);
				Front.renderer.sharedMaterial.SetTextureOffset ("_MainTex", new Vector2 (0, frontY));
				Back.renderer.sharedMaterial.SetTextureOffset ("_MainTex", new Vector2 (0, backY));
				Middle.renderer.sharedMaterial.SetTextureOffset ("_MainTex", new Vector2 (0, middleY));
		}
}
