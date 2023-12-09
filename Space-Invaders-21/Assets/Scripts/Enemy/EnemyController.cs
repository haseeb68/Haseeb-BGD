using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float minPosX;
    public float maxPosX;

    public float minPosY;
    public float maxPosY;

    public float moveDistance = 1f;
    public float timeStep = 1f;

    public float moveDistanceY = 1f;

    bool isMovingRight = true;
    bool isMovingDown = true;

    // Use this for initialization
    void Start()
    {
        // Invoke repeating will be called once after timeStep (2nd parameter) amount,
        // and then repeatedly every timeStep (3rd parameter) amount
        InvokeRepeating("Move", timeStep, timeStep);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Move()
    {
        if (isMovingRight)
        {
            // Moving right
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos + new Vector3(moveDistance, 0f);
            
            transform.position = newPos;
            

            // If aliens group reached the right-most edge, flip their direction
            if (transform.position.x >= maxPosX)
            {
                
                isMovingRight = false;
                if (isMovingDown)
                {
                    // Moving Down
                    Vector3 currentPosY = transform.position;
                    Vector3 newPosY = currentPosY - new Vector3(0f, moveDistanceY);
                    transform.position = newPosY;


                    // If aliens group reached the right-most edge, flip their direction
                    if (transform.position.y <= maxPosY)
                    {
                        isMovingDown = false;
                    }
                }
                else
                {
                    // Moving Up
                    Vector3 currentPosY = transform.position;
                    Vector3 newPosY = currentPosY + new Vector3(0f, moveDistanceY);
                    transform.position = newPosY;

                    // If aliens group reached the left-most edge, flip their direction
                    if (transform.position.y >= minPosY)
                    {
                        isMovingDown = true;
                    }
                }
            }
        }
        else
        {
            // Moving left
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos - new Vector3(moveDistance, 0f);

            transform.position = newPos;

            // If aliens group reached the left-most edge, flip their direction
            if (transform.position.x <= minPosX)
            {
                isMovingRight = true;

                if (isMovingDown)
                {
                    // Moving Down
                    Vector3 currentPosY = transform.position;
                    Vector3 newPosY = currentPosY - new Vector3(0f, moveDistanceY);
                    transform.position = newPosY;


                    // If aliens group reached the right-most edge, flip their direction
                    if (transform.position.y <= maxPosY)
                    {
                        isMovingDown = false;
                    }
                }
                else
                {
                    // Moving Up
                    Vector3 currentPosY = transform.position;
                    Vector3 newPosY = currentPosY + new Vector3(0f, moveDistanceY);
                    transform.position = newPosY;

                    // If aliens group reached the left-most edge, flip their direction
                    if (transform.position.y >= minPosY)
                    {
                        isMovingDown = true;
                    }
                }
            }
        }

        

    }
}