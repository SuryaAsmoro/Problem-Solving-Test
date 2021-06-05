using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;
    public Camera mainCamera;

    [Header("Ball Movement")]
    public Vector2 ballAngle = new Vector2(100, 100);
    public float ballSpeed = 100f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(ballAngle.normalized * ballSpeed);
    }

    private void Update()
    {
        
    }

    void MoveBallByMouse()
    {
        Vector3 target = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        Vector3 moveAngle = target - transform.position;

        if (Vector3.Distance(target, transform.position) > 0.5)
            transform.Translate(moveAngle.normalized * ballSpeed * Time.deltaTime);
    }
}
