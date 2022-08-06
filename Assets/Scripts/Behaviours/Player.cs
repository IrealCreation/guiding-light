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
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision!");
        other.GetComponent<ColliderEffect>().CollidePlayer();
    }
}
