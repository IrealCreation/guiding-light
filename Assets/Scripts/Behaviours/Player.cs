using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 4;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotate(float angle)
    {
        transform.Rotate(0, angle, 0);
    }

    public void Move(Vector3 movement)
    {
        transform.Translate(movement * Speed);
    }

    public void Knockback(Vector3 target)
    {
        Vector3 newPos = Vector3.MoveTowards(transform.position, target, -4f);
        Debug.Log(newPos);
        transform.position = newPos;
    }
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision!");
        other.GetComponent<ColliderEffect>().CollidePlayer(this);
    }
}
