using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnImpact : MonoBehaviour
{
    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
}
