using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static int brickCount = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(brickCount);
        if (brickCount == 20 && SceneManager.GetActiveScene().buildIndex == 0)
        {
            Debug.Log("u r in Level2");
            SceneManager.LoadScene(1);
            Ball.ballServed = false;
        }
        else if (brickCount == 38 && SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene(2);
            Ball.ballServed = false;
        }
    }
}
