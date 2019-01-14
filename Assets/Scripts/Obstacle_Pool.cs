using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Pool : MonoBehaviour {

    [Range(8f, 20f)]
    public float distanceBetweenColumns;

    [Range(0f, 5f)]
    public float gapIncrementBetweenColumns;

    [SerializeField]
    GameObject obstacle_prefab;

    int number_of_obstacles = 3;
    float randY;
    Transform bottomObstacle, topObstacle;

    //if we want to randomize the distances and gaps between columns
    //    [SerializeField]
    //    float minDistanceBetweenColumn, maxDistanceBetweenColumns, minGap, maxGap

    float maxY = 6f;
    float minY = -8f;

    GameObject lastObstacle;

    private void Start()
    {
        GameObject instantiated_obstacle;
        for(int i=0; i<number_of_obstacles; i++)
        {
            instantiated_obstacle = Instantiate(obstacle_prefab, transform);
            if(i==0)
            {
                lastObstacle = instantiated_obstacle;
            }
            else
            {
                Reposition(instantiated_obstacle);
            }
        }
    }

    public void ResetObstacles()
    {
        GameObject selected_obstacle;
        for (int i = 0; i < number_of_obstacles; i++)
        {
            selected_obstacle = transform.GetChild(i).gameObject;
            if (i == 0)
            {
                selected_obstacle.transform.localPosition = obstacle_prefab.transform.localPosition;
                lastObstacle = selected_obstacle;
            }
            else
            {
                Reposition(selected_obstacle);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Reposition(collision.gameObject);
        }
    }

    public void Reposition(GameObject obstacle)
    {
//        float randDistance = Random.Range(minDistanceBetweenColumn, maxDistanceBetweenColumn);
        randY = Random.Range(minY, maxY);
        obstacle.transform.localPosition = new Vector2(lastObstacle.transform.localPosition.x + distanceBetweenColumns, randY);

//        float randGap = Random.Range(minGap, maxGap);
        bottomObstacle = obstacle.transform.Find("Obstacle_Bottom").transform;
        bottomObstacle.localPosition = new Vector2(bottomObstacle.localPosition.x, bottomObstacle.localPosition.y + gapIncrementBetweenColumns);

        topObstacle = obstacle.transform.Find("Obstacle_Top").transform;
        topObstacle.localPosition = new Vector2(topObstacle.localPosition.x, topObstacle.localPosition.y - gapIncrementBetweenColumns);

        lastObstacle = obstacle;
    }

}
