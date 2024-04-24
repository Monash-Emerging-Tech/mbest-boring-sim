using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveCube : MonoBehaviour {
    [SerializeField] private Animator rigAnim;
    [SerializeField] private GameObject bodyBase;

    [SerializeField] private InputActionReference ShowHideBody;
    [SerializeField] private InputActionReference Animation;

    [SerializeField] private InputActionAsset ActionAsset;

    private void OnEnable() 
    {
        if (ActionAsset != null) 
        {
            ActionAsset.Enable(); 
        }

        Animation.action.performed += StartAnimation;
        ShowHideBody.action.performed += ToggleBody;
    }

    private void StartAnimation(InputAction.CallbackContext context)
    {
        
        rigAnim.SetTrigger("StartAnim");
        
    }

    private void ToggleBody(InputAction.CallbackContext context)
    {
        bodyBase.SetActive(!bodyBase.activeSelf);
    }
}
