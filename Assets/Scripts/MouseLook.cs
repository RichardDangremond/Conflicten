using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{

    public InputActionReference HorizontalLook;
    public InputActionReference VerticalLook;
    public float lookSpeed = 1f;
    public Transform CameraTransform;
    float pitch;
    float yaw;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        HorizontalLook.action.performed += HandleHorizontalLookChange;
        VerticalLook.action.performed += HandleVerticalLookChange;
    }

    void HandleHorizontalLookChange(InputAction.CallbackContext obj)
    {
        yaw += -obj.ReadValue<float>();
        transform.localRotation = UnityEngine.Quaternion.AngleAxis(yaw * lookSpeed, UnityEngine.Vector3.up);
    }

    void HandleVerticalLookChange(InputAction.CallbackContext obj)
    {
        pitch += -obj.ReadValue<float>();
        CameraTransform.localRotation = UnityEngine.Quaternion.AngleAxis(pitch * lookSpeed, UnityEngine.Vector3.right);
    }
}