using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, GameActions.IGameplayActions
{
    
    public GameActions gameInput;
    

    private void Start()
    {
        gameInput = new GameActions();
        gameInput.Gameplay.SetCallbacks(this);

        gameInput.Gameplay.Enable();
    }

    #region

    private Action JumpEvent;

    #endregion


    public void OnAttack(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnDoge_Roll(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Jump Event triggered");
            JumpEvent?.Invoke();
        }
    }

    public void OnMoveUp(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        gameInput.Gameplay.Enable();
    }
}
