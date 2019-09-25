using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float jumpPower = 1000f;
    Rigidbody2D rb;
    bool isGround = false;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space) && isGround) // dit moet straks met die knop
        {
                rb.AddForce(Vector2.up * jumpPower * Time.deltaTime * rb.mass * rb.gravityScale);
               isGround = false;
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground" && isGround == false)
        {
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGround = false;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground" && isGround == false)
        {
            isGround = true;
        }
    }
}
