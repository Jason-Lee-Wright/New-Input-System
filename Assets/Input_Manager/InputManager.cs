using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Space was pressed");
        }

        if (Gamepad.current.aButton.wasPressedThisFrame)
        {
            Debug.Log("A was pessed");
        }

    }
}
