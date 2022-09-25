using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed = 5f, ExtraHitSpeed = 2f, MaxSpeed = 30f;

    private int _hitCounter = 0;

    private void Start()
    {
        StartCoroutine(BallStart());
    }

    public IEnumerator BallStart (bool Player1IsStarting = true)
    {
        _hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (Player1IsStarting)
        {
            BallMove(new Vector2(-1, 0));
        }
        else
        {
            BallMove(new Vector2(1, 0));
        }
    }

    public void BallMove(Vector2 direction)
    {
        direction = direction.normalized;

        float speed = Speed + _hitCounter * ExtraHitSpeed;

        Rigidbody2D rb2D = gameObject.GetComponent<Rigidbody2D>();

        rb2D.velocity = direction * speed;
    }

    public void IncreaseHitCounter()
    {
        if (_hitCounter * ExtraHitSpeed <= MaxSpeed)
        {
            _hitCounter++;
        }
    }
}
