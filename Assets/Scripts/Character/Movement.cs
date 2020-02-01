using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        acceleration = 0.2f;
        finalSpeed = 0;
        currentSpeed = 0;
    }

    public float acceleration;
    public int baseSpeed = 5;
    public bool facingRight;
    public int finalSpeed = 0;
    public float currentSpeed;
    public string movingDirection = "none";

    public void moveRight()
    {
        movingDirection = "right";
        finalSpeed = baseSpeed;
        if (!facingRight)
        {
            flip();
        }
    }

    public void moveLeft()
    {
        movingDirection = "left";
        finalSpeed = -baseSpeed;
        if (facingRight)
        {
            flip();
        }
    }

    public void stopMoving()
    {
        movingDirection = "none";
        finalSpeed = 0;
    }

    public void flip()
    {
        facingRight = !facingRight;
        Vector3 localScale = transform.localScale;
        localScale.x = -localScale.x;
        transform.localScale = localScale;
    }

    // Update is called once per frame
    void Update()
    {
        switch(movingDirection)
        {
            case "none":
                if(currentSpeed > 0)
                {
                    currentSpeed -= acceleration;
                }
                else if(currentSpeed < 0)
                {
                    currentSpeed += acceleration;
                }
                else
                {
                    currentSpeed = 0;
                }
                break;
            case "right":
                if (currentSpeed < finalSpeed)
                {
                    currentSpeed += acceleration;
                }
                else
                {
                    currentSpeed = finalSpeed;
                }
                break;
            case "left":
                if (currentSpeed > finalSpeed)
                {
                    currentSpeed -= acceleration;
                }
                else
                {
                    currentSpeed = finalSpeed;
                }
                break;
            default:
                break;
        }
        Vector3 movement = new Vector3(currentSpeed, 0);
        transform.position += Time.deltaTime * movement;
    }
}
