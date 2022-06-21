using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : SingletonBehaviour<PlayerController>
{
    [SerializeField] private PlayerMovementController _movementController;
    [SerializeField] private PlayerAnimationController _animationController;
    [SerializeField] private PlayerTriggerController _triggerController;
    [SerializeField] private PlayerStickController _stickController;

    private bool _isInteractable = false;

    protected override void Initialize()
    {

    }

    public void SetInteractable(bool isInteractable)
    {
        _isInteractable = isInteractable;

        _movementController.SetInteractable(_isInteractable);
        _animationController.SetInteractable(_isInteractable);
    }

    public void SetInitialState()
    {
        SetInteractable(true);
        _animationController.SetAnimationState(PlayerAnimationController.AnimationState.Movement);
        _triggerController.DetectTriggers(true);
        _stickController.AddSticks();
    }
}