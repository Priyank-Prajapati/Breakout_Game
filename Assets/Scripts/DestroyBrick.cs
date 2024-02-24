using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyBrick : MonoBehaviour
{
    public int counter=0;
    public GameObject expand;
    public GameObject laser;
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (counter == 0)
        {
            GetComponent<AudioSource>().Play();
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            counter = 1;
        }
        else if (counter == 1)
        {
            GetComponent<AudioSource>().Play();
            gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
            counter = 2;
        }
        else if (counter == 2)
        {
            GetComponent<AudioSource>().Play();
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            counter = 3;
        }
        else if (counter == 3)
        {
            GetComponent<AudioSource>().Play();
            counter = 0;
            LevelController.brickCount++;
            int rand = Random.Range(1, 10);
            if(rand%2 == 0)
                expand = Instantiate(expand, collision.transform.position, collision.transform.rotation);
            else
                laser = Instantiate(laser, collision.transform.position, collision.transform.rotation);

            Destroy(gameObject);
        }
    }
}