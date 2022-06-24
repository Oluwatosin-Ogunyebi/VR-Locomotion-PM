using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandManagerScript : MonoBehaviour
{
    public Animator handAnimator;

    public InputActionReference gripButton;

    private void Start()
    {
        gripButton.action.started += Action_started;
        gripButton.action.canceled += Action_canceled;
    }

    private void Action_canceled(InputAction.CallbackContext obj)
    {
        Release();
    }

    private void Action_started(InputAction.CallbackContext obj)
    {
        Gripped();
    }

    public void Gripped()
    {
        handAnimator.SetBool("isGripped", true);
    }

    public void Release()
    {
        handAnimator.SetBool("isGripped", false);
    }
}
