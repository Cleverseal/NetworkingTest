using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    float moveX, moveY;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        rb.MovePosition((Vector2)transform.position + new Vector2(moveX, moveY) * 1);

	}
}
