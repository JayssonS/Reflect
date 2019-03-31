using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public bool isOppositePlayer;
    Rigidbody2D rigid;

	// Use this for initialization
	void Start ()
    {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (!isOppositePlayer)
        {
            if (Input.GetAxisRaw("Horizontal") > .1 || Input.GetAxisRaw("Horizontal") < -.1)
            {
                transform.position = new Vector2((Time.deltaTime * speed * Input.GetAxisRaw("Horizontal")) + transform.position.x, transform.position.y);
            }

            if (Input.GetAxisRaw("Vertical") > .1)
            {
                transform.position = new Vector2(transform.position.x, (Time.deltaTime * speed * Input.GetAxisRaw("Vertical")) + transform.position.y);
            }
        }
        else
        {
            if (Input.GetAxisRaw("Horizontal") > .1 || Input.GetAxisRaw("Horizontal") < -.1)
            {
                transform.position = new Vector2((Time.deltaTime * speed * -Input.GetAxisRaw("Horizontal")) + transform.position.x, transform.position.y);
            }

            if (Input.GetAxisRaw("Vertical") > .1)
            {
                transform.position = new Vector2(transform.position.x, (Time.deltaTime * speed * Input.GetAxisRaw("Vertical")) + transform.position.y);
            }
        }
	}
}
