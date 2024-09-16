using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ThirdPersonCam : MonoBehaviour
{
    [Header("References")]
    public Transform Orientation;
    public Transform Player;
    public Transform PlayerObj;

    public float RotationSpeed;

    public Transform CombatLookAt;

    public GameObject thirdPersonCam;
    public GameObject combatCam;
    public GameObject topDownCam;

    public CameraStyle CurrentCameraStyle;
    public enum CameraStyle
    {
        Standard,
        Combat,
        Topdown
    }


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        // Switch Between Camera Styles
        if (Input.GetKeyDown(KeyCode.Alpha1)) {SwitchCameraStyle(CameraStyle.Standard);}
        if (Input.GetKeyDown(KeyCode.Alpha2)) {SwitchCameraStyle(CameraStyle.Combat);}
        if (Input.GetKeyDown(KeyCode.Alpha3)) {SwitchCameraStyle(CameraStyle.Topdown);}

        // Rotate the Orientation of the Camera
        Vector3 viewDir = Player.position - new Vector3(transform.position.x, Player.position.y, transform.position.z);
        Orientation.forward = viewDir.normalized;
    }

    private void SwitchCameraStyle(CameraStyle NewCameraStyle)
    {
        combatCam.SetActive(false);
        thirdPersonCam.SetActive(false);
        topDownCam.SetActive(false);

        if (NewCameraStyle == CameraStyle.Standard) thirdPersonCam.SetActive(true);
        if (NewCameraStyle == CameraStyle.Combat) combatCam.SetActive(true);
        if (NewCameraStyle == CameraStyle.Topdown) topDownCam.SetActive(true);

        CurrentCameraStyle = NewCameraStyle;
    }
}
