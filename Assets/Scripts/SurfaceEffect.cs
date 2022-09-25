using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceEffect : MonoBehaviour
{
    public float BounceEffect;
    public float StickyEffect;
    public Ball BallMovement;

    

    private void PaddleBounce(Collision2D col)
    {
        Vector3 ballPosition = transform.position;
        Vector3 paddlePosition = col.gameObject.transform.position;

        float paddleHeight = col.collider.bounds.size.y;
        float x;
        if (col.gameObject.name == "Paddle1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - paddlePosition.y) / paddleHeight;

        BallMovement.IncreaseHitCounter();
        BallMovement.BallMove(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Paddle1" || collision.gameObject.name == "Paddle2")
        {
            PaddleBounce(collision);
        }

        else if (collision.gameObject.name == "EastWall")
        {

        }

        else if (collision.gameObject.name == "WestWall")
        {

        }
        
    }

}
