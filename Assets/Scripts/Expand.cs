using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expand : MonoBehaviour
{
    public GameObject paddle;
    //public AudioSource powerup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.CompareTag("Paddle"))
        {
            GetComponent<AudioSource>().Play();
            Paddle.rbody.transform.localScale = new Vector2(((Paddle.rbody.transform.localScale.x * 25) / 100) + Paddle.rbody.transform.localScale.x, Paddle.rbody.transform.localScale.y);
            Destroy(gameObject,0.1f);
        }
    }
}
