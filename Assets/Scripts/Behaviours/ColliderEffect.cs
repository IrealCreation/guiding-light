using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEffect : MonoBehaviour
{
    public AudioSource SoundEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollidePlayer()
    {
        SoundEffect.Play();
    }
}
