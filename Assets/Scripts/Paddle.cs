using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;
    public static Rigidbody2D rbody;
    

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizon = Input.GetAxis("Horizontal");

        rbody.velocity = new Vector2(horizon, 0) * speed;
    }
}
