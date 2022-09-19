using UnityEngine;

public class Paddle1Movement : MonoBehaviour
{
    [SerializeField]
    private float _paddleSpeed = 10f;

    private Rigidbody2D _paddleRB;

    private void Awake()
    {
        _paddleRB = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float _vertical = Input.GetAxisRaw("Vertical");

        _paddleRB.velocity = new Vector2(0, _vertical) * _paddleSpeed;
    }
}
