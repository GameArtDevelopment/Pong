using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUPaddleMovement : MonoBehaviour
{
    public float PaddleSpeed = 10f;

    public GameObject Ball;

    private void FixedUpdate()
    {
        if (Mathf.Abs(transform.position.y - base.transform.position.y) > 50)
        {
            if (transform.position.y < base.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * PaddleSpeed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * PaddleSpeed;
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
