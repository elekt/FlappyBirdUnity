using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

    Rigidbody2D rigidbody2D;

    void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(GameController.instance.scrollSpeed, 0);
	}
	
	
	void Update () {
        if(GameController.instance.gameOver) {
            rigidbody2D.velocity = Vector2.zero;
        }
	}
}
