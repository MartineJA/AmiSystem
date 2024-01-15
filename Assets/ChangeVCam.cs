using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class ChangeVCam : MonoBehaviour
{
    [SerializeField]
    private PlayerInput playerInput;

    private InputAction aimAction;

    private CinemachineVirtualCamera vCam;

    [SerializeField]
    private int camPriority = 10;

    // Start is called before the first frame update
    void Awake()
    {
        vCam = GetComponent<CinemachineVirtualCamera>();
        aimAction = playerInput.actions["Aim"];
    }

    // Update is called once per frame
    private void OnEnable()
    {
        aimAction.performed += _ => StartAim();
        aimAction.canceled += _ => CancelAim();
    }

    private void OnDisable()
    {
        aimAction.performed -= _ => StartAim();
        aimAction.canceled -= _ => CancelAim();

    }


    private void StartAim()
    {
        vCam.Priority += camPriority;
    }


    private void CancelAim()
    {
        vCam.Priority -= camPriority;
    }
}
