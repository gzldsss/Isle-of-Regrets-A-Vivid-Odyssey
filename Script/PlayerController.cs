using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sensitivity = 100f;
    public float gravity = 9.81f; // 重力加速度 gravitational acceleration
    public float bobFrequency = 5f;  // 颠簸的频率 frequency of bumps
    public float bobHorizontalAmplitude = 0.1f; // 水平方向的颠簸幅度 Horizontal turbulence
    public float bobVerticalAmplitude = 0.1f; // 垂直方向的颠簸幅度 vertical turbulence
    private float bobbingCounter;

    public Transform cameraTransform; // 指向相机的Transform

    private Vector2 moveInput;
    private Vector2 cameraInput;
    private Vector3 playerVelocity;

    private InputAction moveAction;
    private InputAction cameraAction;

    private CharacterController characterController;
    private float cameraVerticalAngle = 0f;
    public bool IsOnBoat { get; set; } = false;

    private void Awake()
    {
        var gameplayController = new GameplayController();

        moveAction = gameplayController.GamePlay.Move;
        moveAction.Enable();
        moveAction.performed += ctx => moveInput = ctx.ReadValue<Vector2>();

        cameraAction = gameplayController.GamePlay.Camera;
        cameraAction.Enable();
        cameraAction.performed += ctx => cameraInput = ctx.ReadValue<Vector2>();

        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {

        // 处理移动 movement
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        move = transform.TransformDirection(move);

        // 如果角色在地面，则重置Y方向速度
        // If the character is on the ground, reset the Y direction speed
        if (characterController.isGrounded && playerVelocity.y < 0)
        {
        playerVelocity.y = 0f;
        }

        // 打印调试信息 Debugging
        Debug.Log("Is Grounded: " + characterController.isGrounded);
        Debug.Log("Vertical Velocity: " + playerVelocity.y);

        //应用重力 Apply gravity
        playerVelocity.y -= gravity * Time.deltaTime;
        //合并水平和垂直移动 Combine horizontal and vertical movement
        Vector3 combinedMovement = move * moveSpeed + playerVelocity;

        //Player move
        characterController.Move(move * moveSpeed * Time.deltaTime);

        // 处理水平旋转 Handle horizontal rotation 
        transform.Rotate(Vector3.up * cameraInput.x * sensitivity * Time.deltaTime);

       // 处理垂直旋转 Handle vertical rotation
       cameraVerticalAngle -= cameraInput.y * sensitivity * Time.deltaTime;
       cameraVerticalAngle = Mathf.Clamp(cameraVerticalAngle, -90f, 90f); // 限制垂直角度 Limit vertical angle
       cameraTransform.localEulerAngles = new Vector3(cameraVerticalAngle, 0, 0);

        if (characterController.isGrounded)
        {
            if (moveInput.sqrMagnitude > 0.1f)
            { // 角色正在移动 The character is moving
              bobbingCounter += Time.deltaTime * bobFrequency;
              float horizontalBob = Mathf.Sin(bobbingCounter) * bobHorizontalAmplitude;
              float verticalBob = Mathf.Cos(bobbingCounter * 2) * bobVerticalAmplitude;

              // 添加颠簸效果到摄像机位置 Add bump effect to camera position
              cameraTransform.localPosition = new Vector3(horizontalBob, verticalBob, cameraTransform.localPosition.z);
            }
            else
            {
              // 角色静止时，重置摄像机位置 When the character is stationary, reset the camera position
              cameraTransform.localPosition = new Vector3(0, cameraTransform.localPosition.y, cameraTransform.localPosition.z);
            }
        }

    }

}