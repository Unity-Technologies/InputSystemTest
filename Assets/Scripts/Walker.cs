using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class Walker : MonoBehaviour
{
    CharacterController m_CharacterController;
    Transform m_Transform;

    PlayerControls m_Controls;
    Vector2 m_Move;
    float m_YSpeed;
    bool m_IsJumping;
    float m_JumpTimer;

    Tank m_VehicleToEnter = null;

    public float moveSpeed = 2f;
    public float jumpSpeed = 1.5f;
    public float maxJumpTime = 0.5f;

    void Awake()
    {
        m_CharacterController = GetComponent<CharacterController>();
        m_Transform = GetComponent<Transform>();

        m_Controls = new PlayerControls();

        m_Controls.Walking.Movement.performed += ctx => m_Move = ctx.ReadValue<Vector2>();
        m_Controls.Walking.Movement.canceled += ctx => m_Move = Vector2.zero;

        m_Controls.Walking.Jump.performed += ctx => OnJumpStart();
        m_Controls.Walking.Jump.canceled += ctx => OnJumpStop();

        m_Controls.Walking.EnterVehicle.performed += ctx => EnterVehicle();

        jumpSpeed = Mathf.Abs(jumpSpeed);
        m_YSpeed = -jumpSpeed;

        m_Controls.Walking.Enable();
    }

    void Update()
    {
        if (m_CharacterController.enabled)
        {
            m_CharacterController.Move(new Vector3(moveSpeed * m_Move.x, m_YSpeed, moveSpeed * m_Move.y) * Time.deltaTime);
            UpdateJumpState();
        }
    }

    void OnJumpStart()
    {
        if (m_CharacterController.isGrounded && m_IsJumping == false)
        {
            m_IsJumping = true;
            m_YSpeed = jumpSpeed;
            m_JumpTimer = 0f;
        }
    }

    void OnJumpStop()
    {
        if (m_IsJumping)
        {
            StopJump();
        }
    }

    void StopJump()
    {
        m_IsJumping = false;
        m_YSpeed = -jumpSpeed;
    }

    // This relies on deltaTime. It must go in the update loop.
    void UpdateJumpState()
    {
        if (m_IsJumping)
        {
            m_JumpTimer += Time.deltaTime;

            if (m_JumpTimer >= maxJumpTime)
            {
                StopJump();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Tank NewVehicle = other.attachedRigidbody?.GetComponent<Tank>();
        if (NewVehicle != null)
            m_VehicleToEnter = NewVehicle;
    }

    void EnterVehicle()
    {
        if (m_VehicleToEnter == null)
            return;

        m_VehicleToEnter.RiderEnter(this);
        m_CharacterController.enabled = false;
        m_Controls.Walking.Disable();
    }

    public void ExitVehicle()
    {
        m_CharacterController.enabled = true;
        m_Controls.Walking.Enable();
    }
}
