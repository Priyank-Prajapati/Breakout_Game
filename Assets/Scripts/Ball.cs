using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed;
    public static int score;
    public static Text scoreText;
    public static bool ballServed = false;
    public static Rigidbody2D rbody;
    public GameObject paddle;


    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.isKinematic = true;
        scoreText = GameObject.Find("Canvas/Score").GetComponent<Text>();
        gameObject.transform.parent = paddle.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump") && !ballServed)
        {
            gameObject.transform.parent = null;
            rbody.isKinematic = false;
            ballServed = true;
            rbody.velocity = new Vector2(1, 1.2f) * speed;
        }
        //if(gameObject.transform.position.y < -5)
        //{
        //    ballServed = false;
        //    rbody.position = new Vector2(spwancentre.transform.position.x, -4.25f);
        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("brick"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
