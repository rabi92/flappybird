using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Controller : MonoBehaviour {

    [SerializeField]
    float jump_force;

    bool gameover = false;

    Rigidbody2D birdRigidbody;

    [SerializeField]
    GameManager gameManager;
	// Use this for initialization
	void Start () {
        birdRigidbody =  GetComponent<Rigidbody2D>();
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Game Over
        gameover = true;
    }

    public void Jump()
    {
        if(!gameover && !gameManager.isPaused)
        {
            //birdRigidbody.velocity = Vector2.zero;
            //birdRigidbody.AddForce(jump_force * 100f * Vector2.up);
        }
    }
    // Update is called once per frame
    void Update () {
		if(!gameover)
        {
            if(Input.GetMouseButtonDown(0) && !gameManager.isPaused)
            {
                birdRigidbody.velocity = Vector2.zero;
                birdRigidbody.AddForce(jump_force * 100f * Vector2.up);
            }
        }
    }
}
