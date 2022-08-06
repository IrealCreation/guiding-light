using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Player Player;

    public float RotationKeyboardSpeed = 1;
    public float RotationMouseSpeed = 1;

    public bool MouseInputs = false;
    public bool KeyboardInputs = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(KeyboardInputs)
        {
            // Rotate with the keyboard
            if (Input.GetAxis("Horizontal") != 0)
            {
                Player.Rotate(Input.GetAxis("Horizontal") * RotationKeyboardSpeed * Time.deltaTime);
            }

            // Move with the keyboard
            if (Input.GetAxis("Vertical") != 0)
            {
                Player.Move(new Vector3(0, 0, Input.GetAxis("Vertical")) * Time.deltaTime);
            }
        }
        
        if(MouseInputs)
        {
            // Rotate with the mouse
            if (Input.GetAxis("Mouse X") != 0)
            {
                Player.Rotate(Input.GetAxis("Mouse X") * RotationMouseSpeed * Time.deltaTime);
            }

            // Left click: move forward
            if (Input.GetMouseButton(0))
            {
                Player.Move(Vector3.forward * Time.deltaTime);
            }

            // Right click: move back
            if (Input.GetMouseButton(1))
            {
                Player.Move(Vector3.back * Time.deltaTime);
            }
        }
    }
}
