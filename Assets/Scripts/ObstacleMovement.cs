using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    Rigidbody2D column_rigidbody;


	void Start () {
        column_rigidbody = GetComponent<Rigidbody2D>();
//      column_rigidbody.velocity = Vector2.left * GameManager.instance.game_speed;
    }

    // Update is called once per frame
    void Update () {
        if (GameManager.instance.isGameOver)
        {
            column_rigidbody.velocity = Vector2.zero;
        }
        else
        {
            column_rigidbody.velocity = Vector2.left * GameManager.instance.game_speed;
        }

    }
}
