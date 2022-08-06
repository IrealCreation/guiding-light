using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    private bool leftToRight = true;
    private float speed = 5;
    private int maxDistance = 25;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (leftToRight)
        // {
        //     transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        //     if (transform.position.x > maxDistance)
        //         leftToRight = false;
        // }
        // else
        // {
        //     transform.Translate(new Vector3(-1, 0, 0) * (speed * Time.deltaTime));
        //     if (transform.position.x < 0 - maxDistance)
        //         leftToRight = true;
        // }
    }
}
