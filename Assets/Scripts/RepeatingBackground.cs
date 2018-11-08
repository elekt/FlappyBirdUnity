using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    BoxCollider2D groundCollider;
    float groundHorizontalLength;

    void Start () 
    {
        groundCollider = GetComponentInChildren<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;
    }
	
	void Update () {
        Debug.Log(gameObject.transform.position.x);
        if(gameObject.transform.position.x >= groundHorizontalLength) {
            float y = gameObject.transform.position.y;
            gameObject.transform.position = new Vector2(-groundHorizontalLength+0.1f, y);
        }
	}
}
