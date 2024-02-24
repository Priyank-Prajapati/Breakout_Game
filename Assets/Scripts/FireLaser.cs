using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaser : MonoBehaviour
{
    float fireRateDelay = 0.25f;
    float timer = 0;
    public GameObject beam;
    public Transform spawncentre;
    public static bool laserFire = false;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (laserFire)
        {
            if (Input.GetAxis("Fire1") > 0 && counter < 10 && timer > fireRateDelay)
            {
                GameObject gobj = Instantiate(beam, spawncentre.transform.position, spawncentre.transform.rotation);
                counter++;
                timer = 0;
            }
            if (counter == 10)
            {
                laserFire = false;
                counter = 0;
            }
            timer += Time.deltaTime;
        }
    }
}
