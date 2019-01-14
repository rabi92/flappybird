using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Controller : MonoBehaviour {

    [SerializeField]
    float jump_force;

    bool gameover = false;

    Rigidbody2D birdRigidbody;

	
    void Start () {
        birdRigidbody =  GetComponent<Rigidbody2D>();
	}

    public void ResetBird()
    {
        transform.position = Vector2.zero;
        transform.rotation = Quaternion.identity;
        birdRigidbody.velocity = Vector2.zero;
        birdRigidbody.angularVelocity = 0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Game Over
        GameManager.instance.GameOver();
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
            GameManager.instance.UpdateScore();

    }
    // Update is called once per frame
    void Update () {
            if(!GameManager.instance.isGameOver && !GameManager.instance.isPaused && Input.GetMouseButtonDown(0) )
            {
                birdRigidbody.velocity = Vector2.zero;
                birdRigidbody.AddForce(jump_force * 100f * Vector2.up);
            }
        }
}
