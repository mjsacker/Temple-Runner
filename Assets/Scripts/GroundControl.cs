using UnityEngine;
using System.Collections;

public class GroundControl : MonoBehaviour {
	
		public float speed = 0.5F;
		public Renderer rend;
		void Start() {
			rend = GetComponent<Renderer>();
		}
		void Update() {
			float offset = Time.time * speed;
			rend.material.mainTextureOffset = new Vector2(0,-offset);
		}
}
