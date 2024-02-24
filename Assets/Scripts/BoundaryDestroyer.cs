using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryDestroyer : MonoBehaviour
{
    public Transform spawncentre;
    public GameObject ball;
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            ball = Instantiate(ball, spawncentre.transform.position, spawncentre.transform.rotation);
            Ball.ballServed = false;
        }
        Destroy(other.gameObject);
    }
}
