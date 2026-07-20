using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerInputActions inputActions;

    private Vector2 movement;

    void Awake()
    {
        inputActions = new PlayerInputActions();
        inputActions.Enable();
    }

    void Update()
    {
        movement = inputActions.Player.Move.ReadValue<Vector2>();
        Debug.Log(movement);
    }
}
