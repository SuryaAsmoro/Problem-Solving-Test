using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;

    [Header("Ball Movement")]
    public Vector2 ballAngle = new Vector2(100, 100);
    public float ballSpeed = 100f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(ballAngle.normalized * ballSpeed);
    }

}
