using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D rigidbody2D;
    bool isDead;
    Animator animator; 

    public int upForce = 200;

	void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        isDead = false;
	}
	
	void Update () {
        if(!isDead) {
            if(Input.GetMouseButtonDown(0)) {
                rigidbody2D.velocity = Vector2.zero;
                rigidbody2D.AddForce(new Vector2(0, upForce));
                animator.SetTrigger("Flap");
            }
        }		
	}

    void OnCollisionEnter2D(Collision2D collision) {
        isDead = true;
        animator.SetTrigger("Die");
        GameController.instance.BirdDied();
    }
}
