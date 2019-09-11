using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class Walker : MonoBehaviour
{
    CharacterController m_CharacterController;

    PlayerControls m_Controls;
    Vector2 m_Move;
    float m_YSpeed;
    JumpState m_JumpState = JumpState.None;
    float m_JumpTimer;
    
    enum JumpState
    {
        None,
        Up,
        Down
    }

    public float moveSpeed = 2f;
    public float jumpSpeed = 1.5f;
    public float maxJumpTime = 0.5f;

    void Awake()
    {
        m_CharacterController = GetComponent<CharacterController>();

        m_Controls = new PlayerControls();

        m_Controls.Walking.Movement.performed += ctx => m_Move = ctx.ReadValue<Vector2>();
        m_Controls.Walking.Movement.canceled += ctx => m_Move = Vector2.zero;

        m_Controls.Walking.Jump.performed += ctx => OnJumpStart();
        m_Controls.Walking.Jump.canceled += ctx => OnJumpStop();

        jumpSpeed = Mathf.Abs(jumpSpeed);
        m_YSpeed = -jumpSpeed;
    }

    void Update()
    {
        m_CharacterController.Move(new Vector3(moveSpeed * m_Move.x, m_YSpeed, moveSpeed * m_Move.y) * Time.deltaTime);

        UpdateJumpState();
    }

    void OnJumpStart()
    {
        if (m_CharacterController.isGrounded && m_JumpState == JumpState.None)
        {
            m_JumpState = JumpState.Up;
            m_YSpeed = jumpSpeed;
            m_JumpTimer = 0f;
        }
    }

    void OnJumpStop()
    {
        if (m_JumpState == JumpState.Up)
        {
            StopJump();
        }
    }

    void StopJump()
    {
        m_JumpState = JumpState.Down;
        m_YSpeed = -jumpSpeed;
    }

    // This relies on deltaTime. It must go in the update loop.
    void UpdateJumpState()
    {
        if (m_JumpState == JumpState.Up)
        {
            m_JumpTimer += Time.deltaTime;

            if (m_JumpTimer >= maxJumpTime)
            {
                StopJump();
            }
        }
        if (m_JumpState == JumpState.Down && m_CharacterController.isGrounded)
        {
            m_JumpState = JumpState.None;
        }
    }

    void OnEnable()
    {
        m_Controls.Walking.Enable();
    }

    void OnDisable()
    {
        m_Controls.Walking.Disable();
    }
}
