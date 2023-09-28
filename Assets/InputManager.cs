using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [Header("Movement")]
// This variable is used to hold the Input value from WASD, Dpad or Left Stick
    [HideInInspector] public Vector2 moveDirection;

    [Header("Jump")]
    [HideInInspector] public bool canJump;
// These variables are used to hold Input values from Spacebar or South button
    [HideInInspector] public bool jumpPressed, jumpReleased, jumpHeld;

    [Header("Interact")]
    [HideInInspector] public bool canInteract;
// These variables are used to hold Input Values from the F key or East Button
    [HideInInspector] public bool interactPressed, interactReleased, interactHeld;

// These variables are used to hold the current Input source
    private Keyboard _keyboard;

    private void Start()
    {
    //Assign Input Sources to Variables
        _keyboard = Keyboard.current;
    }

    private void Update()
    {
        
        {
            UpdateKeyboardInput();
        }
    }
    
    private void UpdateKeyboardInput()
    {
    // Set the value of moveDirection to be equal to the value of wasd
        moveDirection.x = (_keyboard.dKey.isPressed ? 1 : 0) + (_keyboard.aKey.isPressed ? -1 : 0);
        moveDirection.y = (_keyboard.wKey.isPressed ? 1 : 0) + (_keyboard.sKey.isPressed ? -1 : 0);
    // Set the jump bools when spacebar is interacted with
        jumpPressed = _keyboard.spaceKey.wasPressedThisFrame; // Pressed
        jumpReleased = _keyboard.spaceKey.wasReleasedThisFrame;
        jumpHeld = _keyboard.spaceKey.isPressed; // Held
    // Set the interact bools when the f key is interacted with
        interactPressed = _keyboard.fKey.wasPressedThisFrame;
        interactReleased = _keyboard.fKey.wasReleasedThisFrame;
        interactHeld = _keyboard.fKey.isPressed;
    }

  
}