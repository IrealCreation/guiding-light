using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ICollider
{
    public int Damages;
    public float DistanceToPlayer;
    
    public AudioSource LoopSource;
    public AudioSource CollisionSource;

    public AudioClip LoopClip;
    public AudioClip CollisionClip;
    
    // Start is called before the first frame update
    void Start()
    {
        LoopSource.clip = LoopClip;
        LoopSource.Play();
        CollisionSource.clip = CollisionClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateDistanceToPlayer(Player player)
    {
        DistanceToPlayer = Vector3.Distance(this.transform.position, player.transform.position);
    }

    public void LoopStop()
    {
        LoopSource.mute = true;
    }

    public void LoopPlay()
    {
        LoopSource.mute = false;
    }

    public void CollidePlayer(Player player)
    {
        CollisionSource.Play();
        
        player.Knockback(transform.position);
    }
}
