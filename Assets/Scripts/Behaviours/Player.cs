using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 4;

    /// <summary>
    /// Closest source of each AudioClip.
    /// </summary>
    private Dictionary<AudioClip, Enemy> enemySources;
    
    // Start is called before the first frame update
    void Start()
    {
        enemySources = new Dictionary<AudioClip, Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Called an enemy (only it) or the player (all enemies) has moved, so we can update their relative positions
    /// </summary>
    public void UpdateEnemySource(Enemy enemy)
    {
        if (enemySources.ContainsKey(enemy.LoopClip))
        {
            // We have such a clip already playing, let's check if this new one is nearer...
            // TODO: cache the distance between each current enemySource and the player?
            float newDistance = Vector3.Distance(this.transform.position, enemy.transform.position);
            Debug.Log("Distance of " + enemy.gameObject.name + ": " + newDistance);
            
            if (newDistance < enemySources[enemy.LoopClip].DistanceToPlayer)
            {
                Debug.Log(enemy.gameObject.name + " is nearest!");
                // It is! Stop the previous clip and play this new one!
                enemySources[enemy.LoopClip].LoopStop();
                enemySources[enemy.LoopClip] = enemy;
                enemySources[enemy.LoopClip].LoopPlay();
            }
        }
        else
        {
            // We don't know this clip, so it's automatically the nearest one! Let's store it.
            enemySources[enemy.LoopClip] = enemy;
            enemySources[enemy.LoopClip].LoopPlay();
        }
    }

    public void Rotate(float angle)
    {
        transform.Rotate(0, angle, 0);
    }

    public void Move(Vector3 movement)
    {
        transform.Translate(movement * Speed);
        GameManager.Main.OnPlayerMoved();
    }

    public void Knockback(Vector3 target)
    {
        Vector3 newPos = Vector3.MoveTowards(transform.position, target, -4f);
        Debug.Log(newPos);
        transform.position = newPos;
        GameManager.Main.OnPlayerMoved();
    }
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision!");
        other.GetComponent<ICollider>().CollidePlayer(this);
    }
}
