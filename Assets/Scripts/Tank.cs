using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class Tank : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Transform m_Transform;

    Walker m_Rider;

    PlayerControls m_Controls;
    Vector2 m_Move;

    public GameObject bulletPrefab;
    public Transform fireOrigin;
    public Transform riderOrigin;

    public float moveForceMultiplier = 1000f;
    public float turnTorqueMultiplier = 250f;
    public float maxSpeed = 3f;
    public float maxAngularSpeed = 360f;
    public float bulletSpeed = 5f;

    float m_Steering = 0f;
    float m_Gas = 0f;

    void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Transform = GetComponent<Transform>();

        m_Controls = new PlayerControls();

        m_Controls.Tank.Steering.performed += ctx => m_Steering = ctx.ReadValue<float>();
        m_Controls.Tank.Steering.canceled += ctx => m_Steering = 0f;
        m_Controls.Tank.Gas.performed += ctx => m_Gas = ctx.ReadValue<float>();
        m_Controls.Tank.Gas.canceled += ctx => m_Gas = 0f;

        m_Controls.Tank.Fire.performed += ctx => FireBullet();

        m_Controls.Tank.ExitVehicle.performed += ctx => RiderExit(m_Rider);

        m_Controls.Tank.Disable();
    }

    void FixedUpdate()
    {
        Steer();
        Gas();
    }

    void Steer()
    {
        if (m_Rigidbody.angularVelocity.magnitude < maxAngularSpeed)
            m_Rigidbody.AddTorque(Vector3.up * m_Steering * turnTorqueMultiplier * Time.fixedDeltaTime);
    }

    void Gas()
    {
        if (m_Rigidbody.velocity.magnitude < maxSpeed)
            m_Rigidbody.AddForce(m_Transform.forward * m_Gas * moveForceMultiplier * Time.fixedDeltaTime);
    }

    void FireBullet()
    {
        GameObject NewBullet = Instantiate(bulletPrefab, fireOrigin.position, fireOrigin.rotation);

        // Set bullet velocity equal to the current velocity plus the fire speed
        NewBullet.GetComponent<Rigidbody>().AddForce(m_Rigidbody.velocity + (bulletSpeed * fireOrigin.forward.normalized), ForceMode.VelocityChange);
    }

    public void RiderEnter(Walker NewRider)
    {
        if (m_Rider != null)
        {
            m_Rider.ExitVehicle();
        }

        NewRider.transform.position = riderOrigin.position;
        NewRider.transform.SetParent(riderOrigin);
        m_Rider = NewRider;

        m_Controls.Tank.Enable();
        Debug.Log("RiderEnter");
    }

    public void RiderExit(Walker OldRider)
    {
        if (m_Rider == OldRider)
        {
            OldRider.ExitVehicle();
            OldRider.transform.SetParent(null);
            m_Rider = null;
        }

        m_Controls.Tank.Disable();
        Debug.Log("RiderExit");
    }
}
