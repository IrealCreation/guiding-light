using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEffect : MonoBehaviour
{
    public AudioSource SoundEffect;

    public bool Knockback = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollidePlayer(Player player)
    {
        SoundEffect.Play();

        if (Knockback)
        {
            player.Knockback(transform.position);
        }
    }
}
