using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public float laserspeed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, laserspeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("brick"))
        {
            Destroy(collision.gameObject);
            LevelController.brickCount++;
            Ball.score+=4;
            Ball.scoreText.text = Ball.score.ToString();
            Destroy(gameObject);
        }
    }
}
